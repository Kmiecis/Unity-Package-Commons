using System;

namespace Common
{
    public class DependencyFromScriptableObject : Dependency
    {
        public DependencyFromScriptableObject(Type type = null) :
            base(type)
        {
        }
    }
}