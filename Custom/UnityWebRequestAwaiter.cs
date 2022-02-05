using System;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace Common
{
    public class UnityWebRequestAwaiter : INotifyCompletion
    {
        private readonly UnityWebRequestAsyncOperation _operation;

        public UnityWebRequestAwaiter(UnityWebRequestAsyncOperation operation)
        {
            _operation = operation;
        }

        public void OnCompleted(Action continuation)
        {
            _operation.completed += _ => continuation();
        }

        public bool IsCompleted
        {
            get => _operation.isDone;
        }

        public UnityWebRequest GetResult()
        {
            return _operation.webRequest;
        }
    }

    public static class UnityWebRequestAwaiterExtensions
    {
        public static UnityWebRequestAwaiter GetAwaiter(this UnityWebRequestAsyncOperation self)
        {
            return new UnityWebRequestAwaiter(self);
        }
    }
}
