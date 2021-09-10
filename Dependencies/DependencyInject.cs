using System;

namespace Common
{
    [AttributeUsage(AttributeTargets.Field)]
    public class DependencyInject : Attribute
    {
        public readonly Type type;

        public DependencyInject(Type type = null)
        {
            this.type = type;
        }
    }
}
