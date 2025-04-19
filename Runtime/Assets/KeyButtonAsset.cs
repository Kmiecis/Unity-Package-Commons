using UnityEngine;

namespace Common
{
    [CreateAssetMenu(menuName = nameof(Common) + "/" + nameof(KeyButtonAsset), fileName = nameof(KeyButtonAsset))]
    public sealed class KeyButtonAsset : ScriptableValue<string>
    {
        public KeyButtonAsset()
        {
            _value = string.Empty;
        }

        public bool IsDown()
            => Input.GetButtonDown(_value);

        public bool IsHeld()
            => Input.GetButton(_value);

        public bool IsUp()
            => Input.GetButtonUp(_value);
    }
}
