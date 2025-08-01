using UnityEngine;
using UnityEngine.Events;

namespace Common.Inputs
{
    [AddComponentMenu(nameof(Common) + "/" + nameof(Inputs) + "/Mouse Toggle Handler")]
    public class MouseToggleHandler : MouseClickHandler
    {
        [SerializeField] private UnityEvent<bool> _onValueChanged = new UnityEvent<bool>();
        [SerializeField] private bool _checked;

        public UnityEvent<bool> OnValueChanged
            => _onValueChanged;

        public bool IsChecked
            => _checked;

        public override void OnClick(MouseEventData data)
        {
            base.OnClick(data);

            _onValueChanged.Invoke(_checked);
            _checked = !_checked;
        }

        public override void RemoveAllListeners()
        {
            base.RemoveAllListeners();

            _onValueChanged.RemoveAllListeners();
        }
    }
}