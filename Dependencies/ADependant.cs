namespace Common
{
    public class ADependant : IDependant
    {
        public void Bind()
        {
            Dependencies.Bind(this);
        }

        public void Unbind()
        {
            Dependencies.Unbind(this);
        }
    }
}