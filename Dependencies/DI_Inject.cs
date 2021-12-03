using System;

namespace Common.Dependencies
{
    /// <summary>
    /// Marks a field to have a dependency injected into by <see cref="DI_Binder"/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class DI_Inject : Attribute
    {
        /// <summary>
        /// Allows defining a type by which dependency should be injected
        /// </summary>
        public readonly Type type;

        public DI_Inject(Type type = null)
        {
            this.type = type;
        }
    }
}
