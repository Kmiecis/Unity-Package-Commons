using UnityEngine;

namespace Common
{
    public class FooterButtonAttribute : PropertyAttribute
    {
        public readonly string callback;
        public readonly string name;

        public FooterButtonAttribute(string callback, string name)
        {
            this.callback = callback;
            this.name = name;
        }

        public FooterButtonAttribute(string callback) :
            this(callback, callback)
        {
        }
    }
}