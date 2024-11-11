using UnityEngine;
using UnityEngine.Events;

namespace Common.Inputs
{
    [AddComponentMenu(nameof(Common) + "/" + nameof(Inputs) + "/" + "Mouse Hover Handler")]
    public class MouseHoverHandler : MonoBehaviour
    {
        [SerializeField] protected UnityEvent<MouseEventData> _onHoverBegan = new UnityEvent<MouseEventData>();
        [SerializeField] protected UnityEvent<MouseEventData> _onHoverEnded = new UnityEvent<MouseEventData>();

        private MouseEventData _cache;

        public UnityEvent<MouseEventData> OnHoverBegan
            => _onHoverBegan;

        public UnityEvent<MouseEventData> OnHoverEnded
            => _onHoverEnded;

        public bool IsHovering
            => _cache != null;

        public void OnHoverBegin(MouseEventData data)
        {
            data.source = transform;

            _onHoverBegan.Invoke(data);
            _cache = data;
        }

        public void OnHoverEnd(MouseEventData data)
        {
            if (_cache != null)
            {
                data.source = transform;

                _onHoverEnded.Invoke(data);
                _cache = null;
            }
        }

        public void RemoveAllListeners()
        {
            _onHoverBegan.RemoveAllListeners();
            _onHoverEnded.RemoveAllListeners();
        }

        #region Unity
        private void OnDisable()
        {
            OnHoverEnd(_cache);
        }

        private void OnDestroy()
        {
            RemoveAllListeners();
        }
        #endregion
    }
}