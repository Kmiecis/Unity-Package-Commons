using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class GameObjectExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPrefab(this GameObject self)
        {
            return self.scene.rootCount == 0;
        }
    }
}
