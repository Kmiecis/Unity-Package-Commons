using UnityEngine;

namespace Common
{
    [CreateAssetMenu(menuName = nameof(Common) + "/" + nameof(KeyAxisAsset), fileName = nameof(KeyAxisAsset))]
    public sealed class KeyAxisAsset : ScriptableValue<string>
    {
        public KeyAxisAsset()
        {
            _value = string.Empty;
        }

        public float GetAxisRaw()
            => Input.GetAxisRaw(_value);

        public float GetAxis()
            => Input.GetAxis(_value);
    }
}
