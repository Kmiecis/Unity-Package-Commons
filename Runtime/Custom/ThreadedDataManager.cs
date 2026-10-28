using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Common
{
    public class ThreadedDataManager : MonoBehaviour
    {
        interface IThreadInfo
        {
            void OnReady();
        }

        class ThreadInfo<T> : IThreadInfo
        {
            public readonly Action<T> callback;
            public readonly T data;

            public ThreadInfo(Action<T> callback, T data)
            {
                this.callback = callback;
                this.data = data;
            }

            public void OnReady()
            {
                this.callback(this.data);
            }
        }

        private static Queue<IThreadInfo> _dataQueue = new Queue<IThreadInfo>();
        
        public static void RequestData<T>(Func<T> generator, Action<T> callback)
        {
            ThreadStart threadStart = delegate
            {
                ProcessData(generator, callback);
            };

            new Thread(threadStart).Start();
        }

        private static void ProcessData<T>(Func<T> generator, Action<T> callback)
        {
            T data = generator();
            Enqueue(new ThreadInfo<T>(callback, data));
        }

        private void Update()
        {
            while (TryDequeue(out var threadInfo))
            {
                threadInfo.OnReady();
            }
        }

        private static void Enqueue(IThreadInfo threadInfo)
        {
            lock (_dataQueue)
            {
                _dataQueue.Enqueue(threadInfo);
            }
        }

        private static bool TryDequeue(out IThreadInfo threadInfo)
        {
            lock (_dataQueue)
            {
                return _dataQueue.TryDequeue(out threadInfo);
            }
        }
    }
}
