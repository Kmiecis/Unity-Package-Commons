using System;

namespace Common
{
    public class Dependant : Attribute
    {
        public readonly string callback;

        public Dependant(string callback = null)
        {
            this.callback = callback;
        }
    }
}