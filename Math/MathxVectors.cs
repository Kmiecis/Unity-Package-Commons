using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static partial class Mathx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(Vector2 v)
        {
            return (
                IsZero(v.x) &&
                IsZero(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(Vector3 v)
        {
            return (
                IsZero(v.x) &&
                IsZero(v.y) &&
                IsZero(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(Vector4 v)
        {
            return (
                IsZero(v.x) &&
                IsZero(v.y) &&
                IsZero(v.z) &&
                IsZero(v.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(Vector2Int v)
        {
            return (
                IsZero(v.x) &&
                IsZero(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(Vector3Int v)
        {
            return (
                IsZero(v.x) &&
                IsZero(v.y) &&
                IsZero(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOne(Vector2 v)
        {
            return (
                IsOne(v.x) &&
                IsOne(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOne(Vector3 v)
        {
            return (
                IsOne(v.x) &&
                IsOne(v.y) &&
                IsOne(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOne(Vector4 v)
        {
            return (
                IsOne(v.x) &&
                IsOne(v.y) &&
                IsOne(v.z) &&
                IsOne(v.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOne(Vector2Int v)
        {
            return (
                IsOne(v.x) &&
                IsOne(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOne(Vector3Int v)
        {
            return (
                IsOne(v.x) &&
                IsOne(v.y) &&
                IsOne(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity(Vector2 v)
        {
            return (
                float.IsInfinity(v.x) &&
                float.IsInfinity(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity(Vector3 v)
        {
            return (
                float.IsInfinity(v.x) &&
                float.IsInfinity(v.y) &&
                float.IsInfinity(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity(Vector4 v)
        {
            return (
                float.IsInfinity(v.x) &&
                float.IsInfinity(v.y) &&
                float.IsInfinity(v.z) &&
                float.IsInfinity(v.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(Vector2 v)
        {
            return (
                float.IsNaN(v.x) &&
                float.IsNaN(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(Vector3 v)
        {
            return (
                float.IsNaN(v.x) &&
                float.IsNaN(v.y) &&
                float.IsNaN(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(Vector4 v)
        {
            return (
                float.IsNaN(v.x) &&
                float.IsNaN(v.y) &&
                float.IsNaN(v.z) &&
                float.IsNaN(v.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasInfinity(Vector2 v)
        {
            return (
                float.IsInfinity(v.x) ||
                float.IsInfinity(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasInfinity(Vector3 v)
        {
            return (
                float.IsInfinity(v.x) ||
                float.IsInfinity(v.y) ||
                float.IsInfinity(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasInfinity(Vector4 v)
        {
            return (
                float.IsInfinity(v.x) ||
                float.IsInfinity(v.y) ||
                float.IsInfinity(v.z) ||
                float.IsInfinity(v.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasNaN(Vector2 v)
        {
            return (
                float.IsNaN(v.x) ||
                float.IsNaN(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasNaN(Vector3 v)
        {
            return (
                float.IsNaN(v.x) ||
                float.IsNaN(v.y) ||
                float.IsNaN(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasNaN(Vector4 v)
        {
            return (
                float.IsNaN(v.x) ||
                float.IsNaN(v.y) ||
                float.IsNaN(v.z) ||
                float.IsNaN(v.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsValid(Vector2 v)
        {
            return !HasNaN(v) && !HasInfinity(v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsValid(Vector3 v)
        {
            return !HasNaN(v) && !HasInfinity(v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsValid(Vector4 v)
        {
            return !HasNaN(v) && !HasInfinity(v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Lerp(Vector2 a, Vector2 b, Vector2 t)
        {
            return a + Mul(t, b - a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            return a + Mul(t, b - a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Lerp(Vector3 a, Vector3 b, Vector3 t)
        {
            return a + Mul(t, b - a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
            return a + Mul(t, b - a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Lerp(Vector4 a, Vector4 b, Vector4 t)
        {
            return a + Mul(t, b - a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
        {
            return a + Mul(t, b - a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Unlerp(Vector2 a, Vector2 b, Vector2 t)
        {
            return new Vector2(
                Unlerp(a.x, b.x, t.x),
                Unlerp(a.y, b.y, t.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Unlerp(Vector2 a, Vector2 b, float t)
        {
            return new Vector2(
                Unlerp(a.x, b.x, t),
                Unlerp(a.y, b.y, t)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Unlerp(Vector3 a, Vector3 b, Vector3 t)
        {
            return new Vector3(
                Unlerp(a.x, b.x, t.x),
                Unlerp(a.y, b.y, t.y),
                Unlerp(a.z, b.z, t.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Unlerp(Vector3 a, Vector3 b, float t)
        {
            return new Vector3(
                Unlerp(a.x, b.x, t),
                Unlerp(a.y, b.y, t),
                Unlerp(a.z, b.z, t)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Unlerp(Vector4 a, Vector4 b, Vector4 t)
        {
            return new Vector4(
                Unlerp(a.x, b.x, t.x),
                Unlerp(a.y, b.y, t.y),
                Unlerp(a.z, b.z, t.z),
                Unlerp(a.w, b.w, t.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Unlerp(Vector4 a, Vector4 b, float t)
        {
            return new Vector4(
                Unlerp(a.x, b.x, t),
                Unlerp(a.y, b.y, t),
                Unlerp(a.z, b.z, t),
                Unlerp(a.w, b.w, t)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Square(Vector2 v)
        {
            return Mul(v, v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Square(Vector3 v)
        {
            return Mul(v, v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Square(Vector4 v)
        {
            return Mul(v, v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Square(Vector2Int v)
        {
            return Mul(v, v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Square(Vector3Int v)
        {
            return Mul(v, v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Clamp(Vector2 v, Vector2 min, Vector2 max)
        {
            return new Vector2(
                Mathf.Clamp(v.x, min.x, max.x),
                Mathf.Clamp(v.y, min.y, max.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Clamp(Vector2 v, float min, Vector2 max)
        {
            return new Vector2(
                Mathf.Clamp(v.x, min, max.x),
                Mathf.Clamp(v.y, min, max.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Clamp(Vector2 v, Vector2 min, float max)
        {
            return new Vector2(
                Mathf.Clamp(v.x, min.x, max),
                Mathf.Clamp(v.y, min.y, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Clamp(Vector2 v, float min, float max)
        {
            return new Vector2(
                Mathf.Clamp(v.x, min, max),
                Mathf.Clamp(v.y, min, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Clamp(Vector3 v, Vector3 min, Vector3 max)
        {
            return new Vector3(
                Mathf.Clamp(v.x, min.x, max.x),
                Mathf.Clamp(v.y, min.y, max.y),
                Mathf.Clamp(v.z, min.z, max.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Clamp(Vector3 v, float min, Vector3 max)
        {
            return new Vector3(
                Mathf.Clamp(v.x, min, max.x),
                Mathf.Clamp(v.y, min, max.y),
                Mathf.Clamp(v.z, min, max.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Clamp(Vector3 v, Vector3 min, float max)
        {
            return new Vector3(
                Mathf.Clamp(v.x, min.x, max),
                Mathf.Clamp(v.y, min.y, max),
                Mathf.Clamp(v.z, min.z, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Clamp(Vector3 v, float min, float max)
        {
            return new Vector3(
                Mathf.Clamp(v.x, min, max),
                Mathf.Clamp(v.y, min, max),
                Mathf.Clamp(v.z, min, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Clamp(Vector4 v, Vector4 min, Vector4 max)
        {
            return new Vector4(
                Mathf.Clamp(v.x, min.x, max.x),
                Mathf.Clamp(v.y, min.y, max.y),
                Mathf.Clamp(v.z, min.z, max.z),
                Mathf.Clamp(v.w, min.w, max.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Clamp(Vector4 v, float min, Vector4 max)
        {
            return new Vector4(
                Mathf.Clamp(v.x, min, max.x),
                Mathf.Clamp(v.y, min, max.y),
                Mathf.Clamp(v.z, min, max.z),
                Mathf.Clamp(v.w, min, max.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Clamp(Vector4 v, Vector4 min, float max)
        {
            return new Vector4(
                Mathf.Clamp(v.x, min.x, max),
                Mathf.Clamp(v.y, min.y, max),
                Mathf.Clamp(v.z, min.z, max),
                Mathf.Clamp(v.w, min.w, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Clamp(Vector4 v, float min, float max)
        {
            return new Vector4(
                Mathf.Clamp(v.x, min, max),
                Mathf.Clamp(v.y, min, max),
                Mathf.Clamp(v.z, min, max),
                Mathf.Clamp(v.w, min, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Clamp(Vector2Int v, Vector2Int min, Vector2Int max)
        {
            return new Vector2Int(
                Mathf.Clamp(v.x, min.x, max.x),
                Mathf.Clamp(v.y, min.y, max.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Clamp(Vector2Int v, int min, Vector2Int max)
        {
            return new Vector2Int(
                Mathf.Clamp(v.x, min, max.x),
                Mathf.Clamp(v.y, min, max.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Clamp(Vector2Int v, Vector2Int min, int max)
        {
            return new Vector2Int(
                Mathf.Clamp(v.x, min.x, max),
                Mathf.Clamp(v.y, min.y, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Clamp(Vector2Int v, int min, int max)
        {
            return new Vector2Int(
                Mathf.Clamp(v.x, min, max),
                Mathf.Clamp(v.y, min, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Clamp(Vector3Int v, Vector3Int min, Vector3Int max)
        {
            return new Vector3Int(
                Mathf.Clamp(v.x, min.x, max.x),
                Mathf.Clamp(v.y, min.y, max.y),
                Mathf.Clamp(v.z, min.z, max.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Clamp(Vector3Int v, int min, Vector3Int max)
        {
            return new Vector3Int(
                Mathf.Clamp(v.x, min, max.x),
                Mathf.Clamp(v.y, min, max.y),
                Mathf.Clamp(v.z, min, max.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Clamp(Vector3Int v, Vector3Int min, int max)
        {
            return new Vector3Int(
                Mathf.Clamp(v.x, min.x, max),
                Mathf.Clamp(v.y, min.y, max),
                Mathf.Clamp(v.z, min.z, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Clamp(Vector3Int v, int min, int max)
        {
            return new Vector3Int(
                Mathf.Clamp(v.x, min, max),
                Mathf.Clamp(v.y, min, max),
                Mathf.Clamp(v.z, min, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Wrap(Vector2 v, Vector2 min, Vector2 max)
        {
            return new Vector2(
                Wrap(v.x, min.x, max.x),
                Wrap(v.y, min.y, max.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Wrap(Vector2 v, float min, Vector2 max)
        {
            return new Vector2(
                Wrap(v.x, min, max.x),
                Wrap(v.y, min, max.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Wrap(Vector2 v, Vector2 min, float max)
        {
            return new Vector2(
                Wrap(v.x, min.x, max),
                Wrap(v.y, min.y, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Wrap(Vector2 v, float min, float max)
        {
            return new Vector2(
                Wrap(v.x, min, max),
                Wrap(v.y, min, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Wrap(Vector3 v, Vector3 min, Vector3 max)
        {
            return new Vector3(
                Wrap(v.x, min.x, max.x),
                Wrap(v.y, min.y, max.y),
                Wrap(v.z, min.z, max.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Wrap(Vector3 v, float min, Vector3 max)
        {
            return new Vector3(
                Wrap(v.x, min, max.x),
                Wrap(v.y, min, max.y),
                Wrap(v.z, min, max.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Wrap(Vector3 v, Vector3 min, float max)
        {
            return new Vector3(
                Wrap(v.x, min.x, max),
                Wrap(v.y, min.y, max),
                Wrap(v.z, min.z, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Wrap(Vector3 v, float min, float max)
        {
            return new Vector3(
                Wrap(v.x, min, max),
                Wrap(v.y, min, max),
                Wrap(v.z, min, max)
            );
        }

        public static Vector4 Wrap(Vector4 v, Vector4 min, Vector4 max)
        {
            return new Vector4(
                Wrap(v.x, min.x, max.x),
                Wrap(v.y, min.y, max.y),
                Wrap(v.z, min.z, max.z),
                Wrap(v.w, min.w, max.w)
            );
        }

        public static Vector4 Wrap(Vector4 v, float min, Vector4 max)
        {
            return new Vector4(
                Wrap(v.x, min, max.x),
                Wrap(v.y, min, max.y),
                Wrap(v.z, min, max.z),
                Wrap(v.w, min, max.w)
            );
        }

        public static Vector4 Wrap(Vector4 v, Vector4 min, float max)
        {
            return new Vector4(
                Wrap(v.x, min.x, max),
                Wrap(v.y, min.y, max),
                Wrap(v.z, min.z, max),
                Wrap(v.w, min.w, max)
            );
        }

        public static Vector4 Wrap(Vector4 v, float min, float max)
        {
            return new Vector4(
                Wrap(v.x, min, max),
                Wrap(v.y, min, max),
                Wrap(v.z, min, max),
                Wrap(v.w, min, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Wrap(Vector2Int v, Vector2Int min, Vector2Int max)
        {
            return new Vector2Int(
                Wrap(v.x, min.x, max.x),
                Wrap(v.y, min.y, max.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Wrap(Vector2Int v, int min, Vector2Int max)
        {
            return new Vector2Int(
                Wrap(v.x, min, max.x),
                Wrap(v.y, min, max.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Wrap(Vector2Int v, Vector2Int min, int max)
        {
            return new Vector2Int(
                Wrap(v.x, min.x, max),
                Wrap(v.y, min.y, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Wrap(Vector2Int v, int min, int max)
        {
            return new Vector2Int(
                Wrap(v.x, min, max),
                Wrap(v.y, min, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Wrap(Vector3Int v, Vector3Int min, Vector3Int max)
        {
            return new Vector3Int(
                Wrap(v.x, min.x, max.x),
                Wrap(v.y, min.y, max.y),
                Wrap(v.z, min.z, max.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Wrap(Vector3Int v, int min, Vector3Int max)
        {
            return new Vector3Int(
                Wrap(v.x, min, max.x),
                Wrap(v.y, min, max.y),
                Wrap(v.z, min, max.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Wrap(Vector3Int v, Vector3Int min, int max)
        {
            return new Vector3Int(
                Wrap(v.x, min.x, max),
                Wrap(v.y, min.y, max),
                Wrap(v.z, min.z, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Wrap(Vector3Int v, int min, int max)
        {
            return new Vector3Int(
                Wrap(v.x, min, max),
                Wrap(v.y, min, max),
                Wrap(v.z, min, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Saturate(Vector2 v)
        {
            return Clamp(v, Vector2.zero, Vector2.one);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Saturate(Vector3 v)
        {
            return Clamp(v, Vector3.zero, Vector3.one);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Saturate(Vector4 v)
        {
            return Clamp(v, Vector4.zero, Vector4.one);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 SmoothStep(Vector2 v)
        {
            return Mul(v, Mul(v, Sub(3, Mul(2, v))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 SmoothStep(Vector3 v)
        {
            return Mul(v, Mul(v, Sub(3, Mul(2, v))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 SmoothStep(Vector4 v)
        {
            return Mul(v, Mul(v, Sub(3, Mul(2, v))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 SmoothStep(Vector2 a, Vector2 b, Vector2 t)
        {
            return SmoothStep(Unlerp(a, b, t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 SmoothStep(Vector3 a, Vector3 b, Vector3 t)
        {
            return SmoothStep(Unlerp(a, b, t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 SmoothStep(Vector4 a, Vector4 b, Vector4 t)
        {
            return SmoothStep(Unlerp(a, b, t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 SmootherStep(Vector2 v)
        {
            return Mul(v, Mul(v, Mul(v, Add(Mul(v, Sub(Mul(v, 6), 15)), 10))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 SmootherStep(Vector3 v)
        {
            return Mul(v, Mul(v, Mul(v, Add(Mul(v, Sub(Mul(v, 6), 15)), 10))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 SmootherStep(Vector4 v)
        {
            return Mul(v, Mul(v, Mul(v, Add(Mul(v, Sub(Mul(v, 6), 15)), 10))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 SmootherStep(Vector2 a, Vector2 b, Vector2 t)
        {
            return SmootherStep(Unlerp(a, b, t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 SmootherStep(Vector3 a, Vector3 b, Vector3 t)
        {
            return SmootherStep(Unlerp(a, b, t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 SmootherStep(Vector4 a, Vector4 b, Vector4 t)
        {
            return SmootherStep(Unlerp(a, b, t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Remap(Vector2 fromMin, Vector2 fromMax, Vector2 toMin, Vector2 toMax, Vector2 v)
        {
            return Lerp(toMin, toMax, Unlerp(fromMin, fromMax, v));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Remap(Vector3 fromMin, Vector3 fromMax, Vector3 toMin, Vector3 toMax, Vector3 v)
        {
            return Lerp(toMin, toMax, Unlerp(fromMin, fromMax, v));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Remap(Vector4 fromMin, Vector4 fromMax, Vector4 toMin, Vector4 toMax, Vector4 v)
        {
            return Lerp(toMin, toMax, Unlerp(fromMin, fromMax, v));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInRange(Vector2 v, Vector2 min, Vector2 max)
        {
            return (
                IsInRange(v.x, min.x, max.x) &&
                IsInRange(v.y, min.y, max.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInRange(Vector3 v, Vector3 min, Vector3 max)
        {
            return (
                IsInRange(v.x, min.x, max.x) &&
                IsInRange(v.y, min.y, max.y) &&
                IsInRange(v.z, min.z, max.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInRange(Vector4 v, Vector4 min, Vector4 max)
        {
            return (
                IsInRange(v.x, min.x, max.x) &&
                IsInRange(v.y, min.y, max.y) &&
                IsInRange(v.z, min.z, max.z) &&
                IsInRange(v.w, min.w, max.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInRange(Vector2Int v, Vector2Int min, Vector2Int max)
        {
            return (
                IsInRange(v.x, min.x, max.x) &&
                IsInRange(v.y, min.y, max.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInRange(Vector3Int v, Vector3Int min, Vector3Int max)
        {
            return (
                IsInRange(v.x, min.x, max.x) &&
                IsInRange(v.y, min.y, max.y) &&
                IsInRange(v.z, min.z, max.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Reciprocal(Vector2 v)
        {
            return Div(1.0f, v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Reciprocal(Vector3 v)
        {
            return Div(1.0f, v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Reciprocal(Vector4 v)
        {
            return Div(1.0f, v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 ReciprocalSafe(Vector2 v)
        {
            return Reciprocal(Vector2.Max(v, Vector2.one * EPS));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ReciprocalSafe(Vector3 v)
        {
            return Reciprocal(Vector3.Max(v, Vector3.one * EPS));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 ReciprocalSafe(Vector4 v)
        {
            return Reciprocal(Vector4.Max(v, Vector4.one * EPS));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Round(Vector2 v)
        {
            return new Vector2(
                Mathf.Round(v.x),
                Mathf.Round(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Round(Vector3 v)
        {
            return new Vector3(
                Mathf.Round(v.x),
                Mathf.Round(v.y),
                Mathf.Round(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Round(Vector4 v)
        {
            return new Vector4(
                Mathf.Round(v.x),
                Mathf.Round(v.y),
                Mathf.Round(v.z),
                Mathf.Round(v.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Floor(Vector2 v)
        {
            return new Vector2(
                Mathf.Floor(v.x),
                Mathf.Floor(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Floor(Vector3 v)
        {
            return new Vector3(
                Mathf.Floor(v.x),
                Mathf.Floor(v.y),
                Mathf.Floor(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Floor(Vector4 v)
        {
            return new Vector4(
                Mathf.Floor(v.x),
                Mathf.Floor(v.y),
                Mathf.Floor(v.z),
                Mathf.Floor(v.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Ceil(Vector2 v)
        {
            return new Vector2(
                Mathf.Ceil(v.x),
                Mathf.Ceil(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Ceil(Vector3 v)
        {
            return new Vector3(
                Mathf.Ceil(v.x),
                Mathf.Ceil(v.y),
                Mathf.Ceil(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Ceil(Vector4 v)
        {
            return new Vector4(
                Mathf.Ceil(v.x),
                Mathf.Ceil(v.y),
                Mathf.Ceil(v.z),
                Mathf.Ceil(v.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int RoundToInt(Vector2 v)
        {
            return new Vector2Int(
                Mathf.RoundToInt(v.x),
                Mathf.RoundToInt(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int RoundToInt(Vector3 v)
        {
            return new Vector3Int(
                Mathf.RoundToInt(v.x),
                Mathf.RoundToInt(v.y),
                Mathf.RoundToInt(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int FloorToInt(Vector2 v)
        {
            return new Vector2Int(
                Mathf.FloorToInt(v.x),
                Mathf.FloorToInt(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int FloorToInt(Vector3 v)
        {
            return new Vector3Int(
                Mathf.FloorToInt(v.x),
                Mathf.FloorToInt(v.y),
                Mathf.FloorToInt(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int CeilToInt(Vector2 v)
        {
            return new Vector2Int(
                Mathf.CeilToInt(v.x),
                Mathf.CeilToInt(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int CeilToInt(Vector3 v)
        {
            return new Vector3Int(
                Mathf.CeilToInt(v.x),
                Mathf.CeilToInt(v.y),
                Mathf.CeilToInt(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Abs(Vector2 v)
        {
            return new Vector2(
                Mathf.Abs(v.x),
                Mathf.Abs(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Abs(Vector3 v)
        {
            return new Vector3(
                Mathf.Abs(v.x),
                Mathf.Abs(v.y),
                Mathf.Abs(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Abs(Vector4 v)
        {
            return new Vector4(
                Mathf.Abs(v.x),
                Mathf.Abs(v.y),
                Mathf.Abs(v.z),
                Mathf.Abs(v.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Abs(Vector2Int v)
        {
            return new Vector2Int(
                Mathf.Abs(v.x),
                Mathf.Abs(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Abs(Vector3Int v)
        {
            return new Vector3Int(
                Mathf.Abs(v.x),
                Mathf.Abs(v.y),
                Mathf.Abs(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Select(Vector2 a, Vector2 b, bool c)
        {
            return c ? b : a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Select(Vector3 a, Vector3 b, bool c)
        {
            return c ? b : a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Select(Vector4 a, Vector4 b, bool c)
        {
            return c ? b : a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Select(Vector2 a, Vector2 b, Bool2 c)
        {
            return new Vector2(
                Select(a.x, b.x, c.x),
                Select(a.y, b.y, c.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Select(Vector3 a, Vector3 b, Bool3 c)
        {
            return new Vector3(
                Select(a.x, b.x, c.x),
                Select(a.y, b.y, c.y),
                Select(a.z, b.z, c.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Select(Vector4 a, Vector4 b, Bool4 c)
        {
            return new Vector4(
                Select(a.x, b.x, c.x),
                Select(a.y, b.y, c.y),
                Select(a.z, b.z, c.z),
                Select(a.w, b.w, c.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Select(Vector2Int a, Vector2Int b, bool c)
        {
            return c ? b : a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Select(Vector3Int a, Vector3Int b, bool c)
        {
            return c ? b : a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Select(Vector2Int a, Vector2Int b, Bool2 c)
        {
            return new Vector2Int(
                Select(a.x, b.x, c.x),
                Select(a.y, b.y, c.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Select(Vector3Int a, Vector3Int b, Bool3 c)
        {
            return new Vector3Int(
                Select(a.x, b.x, c.x),
                Select(a.y, b.y, c.y),
                Select(a.z, b.z, c.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Step(Vector2 a, Vector2 b)
        {
            return new Vector2(
                Step(a.x, b.x),
                Step(a.y, b.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Step(Vector3 a, Vector3 b)
        {
            return new Vector3(
                Step(a.x, b.x),
                Step(a.y, b.y),
                Step(a.z, b.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Step(Vector4 a, Vector4 b)
        {
            return new Vector4(
                Step(a.x, b.x),
                Step(a.y, b.y),
                Step(a.z, b.z),
                Step(a.w, b.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Step(Vector2Int a, Vector2Int b)
        {
            return new Vector2Int(
                Step(a.x, b.x),
                Step(a.y, b.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Step(Vector3Int a, Vector3Int b)
        {
            return new Vector3Int(
                Step(a.x, b.x),
                Step(a.y, b.y),
                Step(a.z, b.z)
            );
        }

        /// <summary> Returns the componentwise fractional part of a Vector2 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Frac(Vector2 f)
        {
            return f - Floor(f);
        }

        /// <summary> Returns the componentwise fractional part of a Vector3 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Frac(Vector3 f)
        {
            return f - Floor(f);
        }

        /// <summary> Returns the componentwise fractional part of a Vector4 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Frac(Vector4 f)
        {
            return f - Floor(f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mod(Vector2 v, Vector2 m)
        {
            return v - Mul(Floor(Mul(v, Div(1.0f, m))), m);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mod(Vector3 v, Vector3 m)
        {
            return v - Mul(Floor(Mul(v, Div(1.0f, m))), m);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Mod(Vector4 v, Vector4 m)
        {
            return v - Mul(Floor(Mul(v, Div(1.0f, m))), m);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mod(Vector2 v, float m)
        {
            return v - Floor(Mul(v, 1.0f / m)) * m;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mod(Vector3 v, float m)
        {
            return v - Floor(Mul(v, 1.0f / m)) * m;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Mod(Vector4 v, float m)
        {
            return v - Floor(Mul(v, 1.0f / m)) * m;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Permute(Vector2 v, Vector2 p, Vector2 m)
        {
            return Mod(Mul(Add(Mul(p, v), 1.0f), v), m);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Permute(Vector3 v, Vector3 p, Vector3 m)
        {
            return Mod(Mul(Add(Mul(p, v), 1.0f), v), m);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Permute(Vector4 v, Vector4 p, Vector4 m)
        {
            return Mod(Mul(Add(Mul(p, v), 1.0f), v), m);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Permute(Vector2 v, float p, float m)
        {
            return Mod(Mul(Add(Mul(p, v), 1.0f), v), m);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Permute(Vector3 v, float p, float m)
        {
            return Mod(Mul(Add(Mul(p, v), 1.0f), v), m);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Permute(Vector4 v, float p, float m)
        {
            return Mod(Mul(Add(Mul(p, v), 1.0f), v), m);
        }

        /// <summary> Returns the componentwise minimum of two Vector2 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Min(Vector2 a, Vector2 b)
        {
            return new Vector2(
                Mathf.Min(a.x, b.x),
                Mathf.Min(a.y, b.y)
            );
        }

        /// <summary> Returns the componentwise minimum of an Vector2 array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Min(params Vector2[] vs)
        {
            var min = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                min = Min(min, vs[i]);
            return min;
        }

        /// <summary> Returns the componentwise minimum of a Vector2 vector and a float value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Min(Vector2 v, float f)
        {
            return new Vector2(
                Mathf.Min(v.x, f),
                Mathf.Min(v.y, f)
            );
        }

        /// <summary> Returns the componentwise minimum of a float value and a Vector2 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Min(float f, Vector2 v)
        {
            return new Vector2(
                Mathf.Min(f, v.x),
                Mathf.Min(f, v.y)
            );
        }

        /// <summary> Returns the componentwise minimum of two Vector3 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Min(Vector3 a, Vector3 b)
        {
            return new Vector3(
                Mathf.Min(a.x, b.x),
                Mathf.Min(a.y, b.y),
                Mathf.Min(a.z, b.z)
            );
        }

        /// <summary> Returns the componentwise minimum of an Vector3 array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Min(params Vector3[] vs)
        {
            var min = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                min = Min(min, vs[i]);
            return min;
        }

        /// <summary> Returns the componentwise minimum of a Vector3 vector and a float value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Min(Vector3 v, float f)
        {
            return new Vector3(
                Mathf.Min(v.x, f),
                Mathf.Min(v.y, f),
                Mathf.Min(v.z, f)
            );
        }

        /// <summary> Returns the componentwise minimum of a float value and a Vector3 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Min(float f, Vector3 v)
        {
            return new Vector3(
                Mathf.Min(f, v.x),
                Mathf.Min(f, v.y),
                Mathf.Min(f, v.z)
            );
        }

        /// <summary> Returns the componentwise minimum of two Vector4 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Min(Vector4 a, Vector4 b)
        {
            return new Vector4(
                Mathf.Min(a.x, b.x),
                Mathf.Min(a.y, b.y),
                Mathf.Min(a.z, b.z),
                Mathf.Min(a.w, b.w)
            );
        }

        /// <summary> Returns the componentwise minimum of an Vector4 array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Min(params Vector4[] vs)
        {
            var min = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                min = Min(min, vs[i]);
            return min;
        }

        /// <summary> Returns the componentwise minimum of a Vector4 vector and a float value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Min(Vector4 v, float f)
        {
            return new Vector4(
                Mathf.Min(v.x, f),
                Mathf.Min(v.y, f),
                Mathf.Min(v.z, f),
                Mathf.Min(v.w, f)
            );
        }

        /// <summary> Returns the componentwise minimum of a float value and a Vector4 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Min(float f, Vector4 v)
        {
            return new Vector4(
                Mathf.Min(f, v.x),
                Mathf.Min(f, v.y),
                Mathf.Min(f, v.z),
                Mathf.Min(f, v.w)
            );
        }

        /// <summary> Returns the componentwise minimum of two Vector2Int vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Min(Vector2Int a, Vector2Int b)
        {
            return new Vector2Int(
                Mathf.Min(a.x, b.x),
                Mathf.Min(a.y, b.y)
            );
        }

        /// <summary> Returns the componentwise minimum of an Vector2Int array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Min(params Vector2Int[] vs)
        {
            var min = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                min = Min(min, vs[i]);
            return min;
        }

        /// <summary> Returns the componentwise minimum of a Vector2Int vector and an int value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Min(Vector2Int v, int i)
        {
            return new Vector2Int(
                Mathf.Min(v.x, i),
                Mathf.Min(v.y, i)
            );
        }

        /// <summary> Returns the componentwise minimum of an int value and a Vector2Int vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Min(int i, Vector2Int v)
        {
            return new Vector2Int(
                Mathf.Min(i, v.x),
                Mathf.Min(i, v.y)
            );
        }

        /// <summary> Returns the componentwise minimum of two Vector3Int vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Min(Vector3Int a, Vector3Int b)
        {
            return new Vector3Int(
                Mathf.Min(a.x, b.x),
                Mathf.Min(a.y, b.y),
                Mathf.Min(a.z, b.z)
            );
        }

        /// <summary> Returns the componentwise minimum of an Vector3Int array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Min(params Vector3Int[] vs)
        {
            var min = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                min = Min(min, vs[i]);
            return min;
        }

        /// <summary> Returns the componentwise minimum of a Vector3Int vector and an int value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Min(Vector3Int v, int i)
        {
            return new Vector3Int(
                Mathf.Min(v.x, i),
                Mathf.Min(v.y, i),
                Mathf.Min(v.z, i)
            );
        }

        /// <summary> Returns the componentwise minimum of an int value and a Vector3Int vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Min(int i, Vector3Int v)
        {
            return new Vector3Int(
                Mathf.Min(i, v.x),
                Mathf.Min(i, v.y),
                Mathf.Min(i, v.z)
            );
        }

        /// <summary> Returns the componentwise maximum of two Vector2 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Max(Vector2 a, Vector2 b)
        {
            return new Vector2(
                Mathf.Max(a.x, b.x),
                Mathf.Max(a.y, b.y)
            );
        }

        /// <summary> Returns the componentwise maximum of an Vector2 array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Max(params Vector2[] vs)
        {
            var min = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                min = Max(min, vs[i]);
            return min;
        }

        /// <summary> Returns the componentwise maximum of a Vector2 vector and a float value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Max(Vector2 v, float f)
        {
            return new Vector2(
                Mathf.Max(v.x, f),
                Mathf.Max(v.y, f)
            );
        }

        /// <summary> Returns the componentwise maximum of a float value and a Vector2 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Max(float f, Vector2 v)
        {
            return new Vector2(
                Mathf.Max(f, v.x),
                Mathf.Max(f, v.y)
            );
        }

        /// <summary> Returns the componentwise maximum of two Vector3 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Max(Vector3 a, Vector3 b)
        {
            return new Vector3(
                Mathf.Max(a.x, b.x),
                Mathf.Max(a.y, b.y),
                Mathf.Max(a.z, b.z)
            );
        }

        /// <summary> Returns the componentwise maximum of an Vector3 array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Max(params Vector3[] vs)
        {
            var min = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                min = Max(min, vs[i]);
            return min;
        }

        /// <summary> Returns the componentwise maximum of a Vector3 vector and a float value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Max(Vector3 v, float f)
        {
            return new Vector3(
                Mathf.Max(v.x, f),
                Mathf.Max(v.y, f),
                Mathf.Max(v.z, f)
            );
        }

        /// <summary> Returns the componentwise maximum of a float value and a Vector3 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Max(float f, Vector3 v)
        {
            return new Vector3(
                Mathf.Max(f, v.x),
                Mathf.Max(f, v.y),
                Mathf.Max(f, v.z)
            );
        }

        /// <summary> Returns the componentwise maximum of two Vector4 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Max(Vector4 a, Vector4 b)
        {
            return new Vector4(
                Mathf.Max(a.x, b.x),
                Mathf.Max(a.y, b.y),
                Mathf.Max(a.z, b.z),
                Mathf.Max(a.w, b.w)
            );
        }

        /// <summary> Returns the componentwise maximum of an Vector4 array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Max(params Vector4[] vs)
        {
            var min = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                min = Max(min, vs[i]);
            return min;
        }

        /// <summary> Returns the componentwise maximum of a Vector4 vector and a float value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Max(Vector4 v, float f)
        {
            return new Vector4(
                Mathf.Max(v.x, f),
                Mathf.Max(v.y, f),
                Mathf.Max(v.z, f),
                Mathf.Max(v.w, f)
            );
        }

        /// <summary> Returns the componentwise maximum of a float value and a Vector4 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Max(float f, Vector4 v)
        {
            return new Vector4(
                Mathf.Max(f, v.x),
                Mathf.Max(f, v.y),
                Mathf.Max(f, v.z),
                Mathf.Max(f, v.w)
            );
        }

        /// <summary> Returns the componentwise maximum of two Vector2Int vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Max(Vector2Int a, Vector2Int b)
        {
            return new Vector2Int(
                Mathf.Max(a.x, b.x),
                Mathf.Max(a.y, b.y)
            );
        }

        /// <summary> Returns the componentwise maximum of an Vector2Int array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Max(params Vector2Int[] vs)
        {
            var min = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                min = Max(min, vs[i]);
            return min;
        }

        /// <summary> Returns the componentwise maximum of a Vector2Int vector and an int value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Max(Vector2Int v, int i)
        {
            return new Vector2Int(
                Mathf.Max(v.x, i),
                Mathf.Max(v.y, i)
            );
        }

        /// <summary> Returns the componentwise maximum of an int value and a Vector2Int vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Max(int i, Vector2Int v)
        {
            return new Vector2Int(
                Mathf.Max(i, v.x),
                Mathf.Max(i, v.y)
            );
        }

        /// <summary> Returns the componentwise maximum of two Vector3Int vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Max(Vector3Int a, Vector3Int b)
        {
            return new Vector3Int(
                Mathf.Max(a.x, b.x),
                Mathf.Max(a.y, b.y),
                Mathf.Max(a.z, b.z)
            );
        }

        /// <summary> Returns the componentwise maximum of an Vector3Int array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Max(params Vector3Int[] vs)
        {
            var min = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                min = Max(min, vs[i]);
            return min;
        }

        /// <summary> Returns the componentwise maximum of a Vector3Int vector and an int value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Max(Vector3Int v, int i)
        {
            return new Vector3Int(
                Mathf.Max(v.x, i),
                Mathf.Max(v.y, i),
                Mathf.Max(v.z, i)
            );
        }

        /// <summary> Returns the componentwise maximum of an int value and a Vector3Int vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Max(int i, Vector3Int v)
        {
            return new Vector3Int(
                Mathf.Max(i, v.x),
                Mathf.Max(i, v.y),
                Mathf.Max(i, v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Rotate(Vector2 point, float angle)
        {
            float sin = Mathf.Sin(angle);
            float cos = Mathf.Cos(angle);
            return new Vector2(
                (cos * point.x) - (sin * point.y),
                (sin * point.x) + (cos * point.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Rotate(Vector3 point, Quaternion rotation)
        {
            return rotation * point;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 RotateAround(Vector2 point, Vector2 pivot, float angle)
        {
            return Rotate(point - pivot, angle) + pivot;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 RotateAround(Vector3 point, Vector3 pivot, Quaternion rotation)
        {
            return rotation * (point - pivot) + pivot;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Transform(Vector2 point, Vector2 translation, float angle, Vector2 scale)
        {
            return Rotate(Mul(point, scale), angle) + translation;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 InverseTransform(Vector2 point, Vector2 translation, float angle, Vector2 scale)
        {
            return Mul(Rotate(point - translation, -angle), Reciprocal(scale));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Transform(Vector3 point, Vector3 translation, Quaternion rotation, Vector3 scale)
        {
            return Rotate(Mul(point, scale), rotation) + translation;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 InverseTransform(Vector3 point, Vector3 translation, Quaternion rotation, Vector3 scale)
        {
            return Mul(Rotate(point - translation, Quaternion.Inverse(rotation)), Reciprocal(scale));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Average(params Vector2[] vs)
        {
            var r = Vector2.zero;
            for (int i = 0; i < vs.Length; ++i)
                r += vs[i];
            return Div(r, vs.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Average(params Vector3[] vs)
        {
            var r = Vector3.zero;
            for (int i = 0; i < vs.Length; ++i)
                r += vs[i];
            return Div(r, vs.Length);
        }
    }
}
