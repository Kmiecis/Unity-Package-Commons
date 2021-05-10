using System;

namespace Common
{
    public class DependencyFromPrefab : Dependency
    {
        public DependencyFromPrefab(Type type = null) :
            base(type)
        {
        }
    }
}