using System;

namespace Common
{
    public class Install : Attribute
    {
        public readonly string callback;

        public Install(string callback = null)
        {
            this.callback = callback;
        }
    }
}