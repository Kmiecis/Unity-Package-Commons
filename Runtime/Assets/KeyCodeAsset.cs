using UnityEngine;

namespace Common
{
    [CreateAssetMenu(menuName = nameof(Common) + "/" + nameof(KeyCodeAsset), fileName = nameof(KeyCodeAsset))]
    public class KeyCodeAsset : ScriptableValue<KeyCode>
    {
        public bool IsDown()
            => Input.GetKeyDown(_value);

        public bool IsHeld()
            => Input.GetKey(_value);

        public bool IsUp()
            => Input.GetKeyUp(_value);
    }
}