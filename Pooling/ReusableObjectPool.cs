using UnityEngine;

namespace Common.Pooling
{
    public class ReusableObjectPool<T> : AReusablePool<T>
        where T : Object, IReusable
    {
        protected readonly T _prefab;

        public ReusableObjectPool(int capacity, T prefab) :
            base(capacity)
        {
            _prefab = prefab;
        }

        public override T Construct()
        {
            return Object.Instantiate(_prefab);
        }

        public override void Destroy(T item)
        {
            ObjectUtility.DestroySafely(item);
        }
    }
}
