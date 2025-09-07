using System;

namespace Common
{
    public static class USystem
    {
        public static void Dispose<T>(ref T disposable)
            where T : class, IDisposable
        {
            if (disposable != null)
            {
                disposable.Dispose();

                disposable = null;
            }
        }
    }
}