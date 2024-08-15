using UnityEngine;

namespace Common
{
    public class HeaderButtonAttribute : PropertyAttribute
    {
        public readonly string callback;
        public readonly string name;

        public HeaderButtonAttribute(string callback, string name)
        {
            this.callback = callback;
            this.name = name;
        }

        public HeaderButtonAttribute(string callback) :
            this(callback, callback)
        {
        }
    }
}