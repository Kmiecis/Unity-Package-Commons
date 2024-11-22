using UnityEngine;
using UnityEngine.Events;

namespace Common.Inputs
{
    [AddComponentMenu(nameof(Common) + "/" + nameof(Inputs) + "/" + "Mouse Click Handler")]
    public class MouseClickHandler : MonoBehaviour
    {
        [SerializeField] protected UnityEvent<MouseEventData> _onClicked = new UnityEvent<MouseEventData>();

        public UnityEvent<MouseEventData> OnClicked
            => _onClicked;

        public virtual void OnClick(MouseEventData data)
        {
            data.source = transform;

            _onClicked.Invoke(data);
        }

        public void RemoveAllListeners()
        {
            _onClicked.RemoveAllListeners();
        }

        #region Unity
        private void OnDestroy()
        {
            RemoveAllListeners();
        }
        #endregion
    }
}