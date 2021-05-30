using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Common
{
    public class ThreadedDataManager : MonoBehaviour
    {
        private static Queue<IThreadInfo> m_DataQueue = new Queue<IThreadInfo>();
        
        private void Update()
        {
            if (m_DataQueue.Count > 0)
            {
                for (int i = 0; i < m_DataQueue.Count; i++)
                {
                    IThreadInfo threadInfo = m_DataQueue.Dequeue();
                    threadInfo.OnReady();
                }
            }
        }

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
            lock (m_DataQueue)
            {
                m_DataQueue.Enqueue(new ThreadInfo<T>(callback, data));
            }
        }

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
    }
}