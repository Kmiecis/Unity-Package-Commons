using UnityEngine;
using UnityEngine.Events;

namespace Common.Inputs
{
    [AddComponentMenu(nameof(Common) + "/" + nameof(Inputs) + "/Mouse Drag Handler")]
    public class MouseDragHandler : MonoBehaviour
    {
        [SerializeField] protected UnityEvent<MouseEventData> _onDragBegan = new UnityEvent<MouseEventData>();
        [SerializeField] protected UnityEvent<MouseEventData> _onDragging = new UnityEvent<MouseEventData>();
        [SerializeField] protected UnityEvent<MouseEventData> _onDragEnded = new UnityEvent<MouseEventData>();

        private MouseEventData _cache;

        public UnityEvent<MouseEventData> OnDragBegan
            => _onDragBegan;

        public UnityEvent<MouseEventData> OnDragging
            => _onDragging;

        public UnityEvent<MouseEventData> OnDragEnded
            => _onDragEnded;

        public bool IsDragging
            => _cache != null;

        public virtual void OnBeginDrag(MouseEventData data)
        {
            data.source = transform;

            _onDragBegan.Invoke(data);
            _cache = data;
        }

        public virtual void OnDrag(MouseEventData data)
        {
            if (_cache != null)
            {
                data.source = transform;

                _onDragging.Invoke(data);
                _cache = data;
            }
        }

        public virtual void OnEndDrag(MouseEventData data)
        {
            if (_cache != null)
            {
                data.source = transform;

                _onDragEnded.Invoke(data);
                _cache = null;
            }
        }

        public virtual void RemoveAllListeners()
        {
            _onDragBegan.RemoveAllListeners();
            _onDragging.RemoveAllListeners();
            _onDragEnded.RemoveAllListeners();
        }

        #region Unity
        private void OnDisable()
        {
            OnEndDrag(_cache);
        }

        private void OnDestroy()
        {
            RemoveAllListeners();
        }
        #endregion
    }
}