using UnityEngine;

namespace Common.Pooling
{
    public class ReusableComponentPool<T> : AReusablePool<T>
        where T : Component, IReusable<T>
    {
        protected readonly T _prefab;

        public ReusableComponentPool(int capacity, T prefab) :
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
            ObjectUtility.DestroySafely(item.gameObject);
        }
    }
}
