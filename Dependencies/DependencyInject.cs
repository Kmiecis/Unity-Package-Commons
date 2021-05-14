using System;

namespace Common
{
    public class DependencyInject : Attribute
    {
        public readonly Type type;
        public readonly string callback;

        public DependencyInject(Type type = null, string callback = null)
        {
            this.type = type;
            this.callback = callback;
        }

        public DependencyInject(Type type) :
            this(type, null)
        {
        }

        public DependencyInject(string callback) :
            this(null, callback)
        {
        }
    }
}