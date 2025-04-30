using UnityEngine;

namespace Common
{
    public class PlayerPrefFieldAttribute : PropertyAttribute
    {
        public readonly string key;

        public PlayerPrefFieldAttribute(string key)
        {
            this.key = key;
        }
    }
}