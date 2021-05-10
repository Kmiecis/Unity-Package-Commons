using System;

namespace Common
{
    public class Dependant : Attribute
    {
        public readonly string callback;

        public Dependant(string invoke = null)
        {
            this.callback = invoke;
        }
    }
}