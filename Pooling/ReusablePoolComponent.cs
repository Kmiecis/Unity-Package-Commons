using UnityEngine;

namespace Common.Pooling
{
    public class ReusablePoolComponent : MonoBehaviour
    {
        public enum EStartup
        {
            Start,
            Awake,
            Manual
        }

        [Header("Properties")]
        [SerializeField]
        protected EStartup _startup;
        [SerializeField]
        protected int _initialize = 1;
        [Header("Pool")]
        [SerializeField]
        protected int _capacity = 1;
        [SerializeField]
        protected ReusableComponent _prefab;

        private APool<ReusableComponent> _pool;

        public void Initialize()
        {
            _pool.Initialize(_initialize);
        }
        
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
    }
}
