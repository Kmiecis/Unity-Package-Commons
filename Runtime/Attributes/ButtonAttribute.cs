using UnityEngine;

namespace Common
{
    public class ButtonAttribute : PropertyAttribute
    {
        public readonly string callback;
        public readonly string name;

        public ButtonAttribute(string callback, string name)
        {
            this.callback = callback;
            this.name = name;
        }

        public ButtonAttribute(string callback) :
            this(callback, callback)
        {
        }
    }
}