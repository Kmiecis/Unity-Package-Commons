using System;

namespace Common
{
    [AttributeUsage(AttributeTargets.Class)]
    public class NamedReferenceAttribute : Attribute
    {
        public readonly string name;
        public readonly string path;

        public NamedReferenceAttribute(string name = null, string path = null)
        {
            this.name = name;
            this.path = path;
        }
    }
}