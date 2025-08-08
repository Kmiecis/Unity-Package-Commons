using UnityEngine;

namespace Common
{
    public class GameBehaviour : MonoBehaviour
    {
        public virtual bool IsActive
        {
            get => gameObject.activeSelf;
        }

        public virtual bool SetActive(bool value)
        {
            if (this)
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
            if (this)
            {
                UObject.Destroy(this);
            }
        }

        public virtual void Destroy()
        {
            if (this)
            {
                UObject.Destroy(gameObject);
            }
        }
    }
}