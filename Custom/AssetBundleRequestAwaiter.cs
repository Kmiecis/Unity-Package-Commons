using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public class AssetBundleRequestAwaiter : INotifyCompletion
    {
        private readonly AssetBundleRequest _request;

        public AssetBundleRequestAwaiter(AssetBundleRequest request)
        {
            _request = request;
        }

        public void OnCompleted(Action continuation)
        {
            _request.completed += _ => continuation();
        }

        public bool IsCompleted
        {
            get => _request.isDone;
        }

        public AssetBundleRequest GetResult()
        {
            return _request;
        }
    }

    public static class AssetBundleRequestAwaiterExtensions
    {
        public static AssetBundleRequestAwaiter GetAwaiter(this AssetBundleRequest self)
        {
            return new AssetBundleRequestAwaiter(self);
        }
    }
}
