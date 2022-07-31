using UnityEngine;
using Common.Extensions;

namespace Common
{
    public static class ObjectUtility
    {
        public static void Destroy<T>(ref T obj)
            where T : Object
        {
            if (obj != null)
            {
                obj.Destroy();
                obj = null;
            }
        }
    }
}