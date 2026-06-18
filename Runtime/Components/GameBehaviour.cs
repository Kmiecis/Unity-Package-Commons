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
            gameObject.SetActive(value);

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

        public void Enable()
        {
            enabled = true;
        }

        public void Disable()
        {
            enabled = false;
        }

        public virtual void Remove()
        {
            UComponent.Remove(this);
        }

        public virtual void Destroy()
        {
            UComponent.Destroy(this);
        }
    }
}