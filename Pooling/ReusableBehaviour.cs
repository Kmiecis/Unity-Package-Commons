using UnityEngine;

namespace Common.Pooling
{
    public class ReusableBehaviour : MonoBehaviour, IReusable<ReusableBehaviour>
    {
        protected IPool<ReusableBehaviour> _pool;

        public void Return()
        {
            _pool.Return(this);
        }

        public void OnBorrow(IPool<ReusableBehaviour> pool)
        {
            _pool = pool;
            gameObject.SetActive(true);
        }

        public void OnReturn()
        {
            gameObject.SetActive(false);
            _pool = null;
        }
    }
}
