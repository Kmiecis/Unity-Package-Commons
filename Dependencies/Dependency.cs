using System;

namespace Common
{
    public abstract class Dependency : Attribute
    {
        public readonly Type type;

        public Dependency(Type type = null)
        {
            this.type = type;
        }
    }
}