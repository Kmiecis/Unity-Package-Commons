using System;

namespace Common
{
    public class DependencyNew : Dependency
    {
        public readonly object[] args;

        public DependencyNew(Type type = null, object[] args = null) :
            base(type)
        {
            this.args = args;
        }

        public DependencyNew(Type type) :
            this(type, null)
        {
        }

        public DependencyNew(object[] args) :
            this(null, args)
        {
        }
    }
}