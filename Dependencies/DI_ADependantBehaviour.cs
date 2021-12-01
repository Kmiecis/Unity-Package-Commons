using UnityEngine;

namespace Common.Dependencies
{
    /// <summary>
    /// Base behaviour for managing lifetime of its dependencies
    /// </summary>
    public abstract class DI_ADependantBehaviour : MonoBehaviour
    {
        protected virtual void Awake()
        {
            DI_Manager.Bind(this);
        }

        protected virtual void OnDestroy()
        {
            DI_Manager.Unbind(this);
        }
    }
}
