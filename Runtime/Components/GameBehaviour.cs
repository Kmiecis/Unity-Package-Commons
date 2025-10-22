using UnityEngine;

namespace Common
{
    public class GameBehaviour : MonoBehaviour
    {
        public Transform parent
        {
            get => transform.parent;
        }

        public Transform root
        {
            get => transform.root;
        }

        public virtual bool IsActive
        {
            get => gameObject.activeSelf;
        }

        public virtual bool SetActive(bool value)
        {
            if (gameObject != null)
            {
                gameObject.SetActive(value);
            }
            return value;
        }

        public virtual void SetParent(Transform parent, bool worldPositionStays = false)
        {
            transform.SetParent(parent, worldPositionStays);
        }

        public bool ToggleActive()
        {
            return SetActive(!IsActive);
        }

        public void ForceActive()
        {
            if (!IsActive)
            {
                SetActive(true);
            }
        }

        public void ForceInactive()
        {
            if (IsActive)
            {
                SetActive(false);
            }
        }

        public virtual void Remove()
        {
            if (this != null)
            {
                UObject.Destroy(this);
            }
        }

        public virtual void Destroy()
        {
            if (this != null && gameObject != null)
            {
                UObject.Destroy(gameObject);
            }
        }
    }
}