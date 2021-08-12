namespace Common
{
    public class Dependant : IDependant
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