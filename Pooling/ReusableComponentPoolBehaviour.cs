using UnityEngine;

namespace Common.Pooling
{
    public class ReusableComponentPoolBehaviour<T> : MonoBehaviour, IPool<T>
        where T : Component, IReusable<T>
    {
        public enum EStartup
        {
            Manual,
            Awake,
            Start
        }

        [Header("Properties")]
        [SerializeField]
        protected EStartup _startup = EStartup.Start;
        [SerializeField]
        protected int _initialize = 1;
        [Header("Pool")]
        [SerializeField]
        protected int _capacity = 1;
        [SerializeReference]
        protected T _prefab;

        private ReusableComponentPool<T> _pool;

        public T Borrow()
        {
            return _pool.Borrow();
        }

        public void Return(T item)
        {
            _pool.Return(item);
        }

        public void Initialize()
        {
            if (_startup == EStartup.Manual)
                _pool.Initialize(_initialize);
        }

        protected virtual void Awake()
        {
            _pool = new ReusableComponentPool<T>(_capacity, _prefab);
            if (_startup == EStartup.Awake)
                _pool.Initialize(_initialize);
        }

        protected virtual void Start()
        {
            if (_startup == EStartup.Start)
                _pool.Initialize(_initialize);
        }
    }
}
