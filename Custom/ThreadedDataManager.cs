using Common.Extensions;
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
            lock (_dataQueue)
            {
                _dataQueue.Enqueue(new ThreadInfo<T>(callback, data));
            }
        }

        private void Update()
        {
            while (_dataQueue.TryDequeue(out var threadInfo))
            {
                threadInfo.OnReady();
            }
        }
    }
}
