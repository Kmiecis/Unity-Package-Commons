using UnityEngine;

namespace Common
{
    public class PlayerPrefFieldAttribute : PropertyAttribute
    {
        public readonly string key;

        public PlayerPrefFieldAttribute(string key = null)
        {
            this.key = key;
        }
    }
}