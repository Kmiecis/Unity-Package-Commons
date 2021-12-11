using UnityEngine;

namespace Common.Pooling
{
    public class ReusableComponent : MonoBehaviour, IReusable
    {
        public void OnBorrow()
        {
            gameObject.SetActive(true);
        }

        public void OnReturn()
        {
            gameObject.SetActive(false);
        }
    }
}
