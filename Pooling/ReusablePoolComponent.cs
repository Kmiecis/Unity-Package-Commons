using UnityEngine;

namespace Common.Pooling
{
    public class ReusablePoolComponent : MonoBehaviour, IPoolProvider<ReusableComponent>
    {
        public enum EStartup
        {
            Start,
            Awake,
            Manual
        }

        [SerializeField]
        protected EStartup _startup;
        [SerializeField]
        protected int _capacity = 1;
        [SerializeField]
        protected ReusableComponent _prefab;
        [SerializeField]
        protected int _initialize = 1;

        private APool<ReusableComponent> _pool;
        
        protected virtual void Awake()
        {
            _pool = new ReusableObjectPool<ReusableComponent>(_capacity, _prefab);
            if (_startup == EStartup.Awake)
                _pool.Initialize(_initialize);
        }

        protected virtual void Start()
        {
            if (_startup == EStartup.Start)
                _pool.Initialize(_initialize);
        }

        public IPool<ReusableComponent> GetPool()
        {
            return _pool;
        }
    }
}
