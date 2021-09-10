using UnityEngine;

namespace Common
{
    public class DependantBehaviour : MonoBehaviour
    {
        protected virtual void Awake()
        {
            Dependencies.Bind(this);
        }

        protected virtual void OnDestroy()
        {
            Dependencies.Unbind(this);
        }
    }
}
