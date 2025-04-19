using System.Linq;
using UnityEngine;

namespace Common
{
    [CreateAssetMenu(menuName = nameof(Common) + "/" + nameof(KeyCodesAsset), fileName = nameof(KeyCodesAsset))]
    public class KeyCodesAsset : ScriptableValues<KeyCode>
    {
        public bool IsDown()
            => _values.Any(Input.GetKeyDown) && _values.Except(_values.Where(Input.GetKeyDown)).All(Input.GetKey);

        public bool IsHeld()
            => _values.All(Input.GetKey);

        public bool IsUp()
            => _values.Any(Input.GetKeyUp) && _values.Except(_values.Where(Input.GetKeyUp)).All(Input.GetKey);
    }
}