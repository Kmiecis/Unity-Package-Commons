using System;

namespace Common
{
    public class DependencyInstall : Attribute
    {
        public readonly Type type;
        public readonly object[] args;

        public DependencyInstall(Type type = null, object[] args = null)
        {
            this.type = type;
            this.args = args;
        }
        
        public DependencyInstall(Type type) :
            this(type, null)
        {
        }

        public DependencyInstall(object[] args) :
            this(null, args)
        {
        }
    }
}