namespace Common.Dependencies
{
    /// <summary>
    /// Base class for managing lifetime of its dependencies
    /// </summary>
    public abstract class DI_ADependant : DI_IDependant
    {
        public void Bind()
        {
            DI_Manager.Bind(this);
        }

        public void Unbind()
        {
            DI_Manager.Unbind(this);
        }
    }
}
