using UnityEngine;
using UnityEngine.EventSystems;

namespace Common.Extensions
{
    public static class RaycastResultExtensions
    {
        public static bool TryGetGameObject(this RaycastResult self, out GameObject gameObject)
        {
            gameObject = self.gameObject;
            return gameObject != null;
        }
    }
}