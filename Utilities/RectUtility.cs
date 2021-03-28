using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class RectUtility
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3[] GetRect3D(Vector3 center, Vector3 normal, Vector2 size)
        {
            return GetRect3D(center, normal, size.x, size.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3[] GetRect3D(Vector3 center, Vector3 normal, float width, float height)
        {
            var widthHalf = width * 0.5f;
            var heightHalf = height * 0.5f;

            var result = new Vector3[]
            {
                new Vector3(-widthHalf, 0.0f, -heightHalf),
                new Vector3(-widthHalf, 0.0f, +heightHalf),
                new Vector3(+widthHalf, 0.0f, +heightHalf),
                new Vector3(+widthHalf, 0.0f, -heightHalf)
            };

            var rotation = Quaternion.FromToRotation(Vector3.up, normal);
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = rotation * result[i] + center;
            }

            return result;
        }
    }
}