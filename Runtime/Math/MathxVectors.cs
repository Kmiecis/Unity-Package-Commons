using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static partial class Mathx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Approximately(Vector2 a, Vector2 b)
        {
            return (
                Mathf.Approximately(a.x, b.x) &&
                Mathf.Approximately(a.y, b.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Approximately(Vector2 v, float f)
        {
            return (
                Mathf.Approximately(v.x, f) &&
                Mathf.Approximately(v.y, f)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Approximately(float f, Vector2 v)
        {
            return (
                Mathf.Approximately(f, v.x) &&
                Mathf.Approximately(f, v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Approximately(Vector3 a, Vector3 b)
        {
            return (
                Mathf.Approximately(a.x, b.x) &&
                Mathf.Approximately(a.y, b.y) &&
                Mathf.Approximately(a.z, b.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Approximately(Vector3 v, float f)
        {
            return (
                Mathf.Approximately(v.x, f) &&
                Mathf.Approximately(v.y, f) &&
                Mathf.Approximately(v.z, f)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Approximately(float f, Vector3 v)
        {
            return (
                Mathf.Approximately(f, v.x) &&
                Mathf.Approximately(f, v.y) &&
                Mathf.Approximately(f, v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Approximately(Vector4 a, Vector4 b)
        {
            return (
                Mathf.Approximately(a.x, b.x) &&
                Mathf.Approximately(a.y, b.y) &&
                Mathf.Approximately(a.z, b.z) &&
                Mathf.Approximately(a.w, b.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Approximately(Vector4 v, float f)
        {
            return (
                Mathf.Approximately(v.x, f) &&
                Mathf.Approximately(v.y, f) &&
                Mathf.Approximately(v.z, f) &&
                Mathf.Approximately(v.w, f)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Approximately(float f, Vector4 v)
        {
            return (
                Mathf.Approximately(f, v.x) &&
                Mathf.Approximately(f, v.y) &&
                Mathf.Approximately(f, v.z) &&
                Mathf.Approximately(f, v.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Approximately(Color a, Color b)
        {
            return (
                Mathf.Approximately(a.r, b.r) &&
                Mathf.Approximately(a.g, b.g) &&
                Mathf.Approximately(a.b, b.b) &&
                Mathf.Approximately(a.a, b.a)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Approximately(Color c, float f)
        {
            return (
                Mathf.Approximately(c.r, f) &&
                Mathf.Approximately(c.g, f) &&
                Mathf.Approximately(c.b, f) &&
                Mathf.Approximately(c.a, f)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Approximately(float f, Color c)
        {
            return (
                Mathf.Approximately(f, c.r) &&
                Mathf.Approximately(f, c.g) &&
                Mathf.Approximately(f, c.b) &&
                Mathf.Approximately(f, c.a)
            );
        }

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
        public static float SqrDistance(Vector2 a, Vector2 b)
        {
            var f0 = b.x - a.x;
            var f1 = b.y - a.y;
            return f0 * f0 + f1 * f1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SqrDistance(Vector3 a, Vector3 b)
        {
            var f0 = b.x - a.x;
            var f1 = b.y - a.y;
            var f2 = b.z - a.z;
            return f0 * f0 + f1 * f1 + f2 * f2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            return a + Mul(t, b - a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Lerp(Vector2 a, Vector2 b, Vector2 t)
        {
            return a + Mul(t, b - a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
            return a + Mul(t, b - a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Lerp(Vector3 a, Vector3 b, Vector3 t)
        {
            return a + Mul(t, b - a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
        {
            return a + Mul(t, b - a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Lerp(Vector4 a, Vector4 b, Vector4 t)
        {
            return a + Mul(t, b - a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rect Lerp(Rect a, Rect b, float t)
        {
            return new Rect(
                Lerp(a.x, b.x, t),
                Lerp(a.y, b.y, t),
                Lerp(a.width, b.width, t),
                Lerp(a.height, b.height, t)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 QLerp(Vector2 a, Vector2 b, Vector2 c, float t)
        {
            var l = Lerp(a, b, t);
            var r = Lerp(b, c, t);
            return Lerp(l, r, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 QLerp(Vector2 a, Vector2 b, Vector2 c, Vector2 t)
        {
            var l = Lerp(a, b, t);
            var r = Lerp(b, c, t);
            return Lerp(l, r, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 QLerp(Vector3 a, Vector3 b, Vector3 c, float t)
        {
            var l = Lerp(a, b, t);
            var r = Lerp(b, c, t);
            return Lerp(l, r, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 QLerp(Vector3 a, Vector3 b, Vector3 c, Vector3 t)
        {
            var l = Lerp(a, b, t);
            var r = Lerp(b, c, t);
            return Lerp(l, r, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 QLerp(Vector4 a, Vector4 b, Vector4 c, float t)
        {
            var l = Lerp(a, b, t);
            var r = Lerp(b, c, t);
            return Lerp(l, r, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 QLerp(Vector4 a, Vector4 b, Vector4 c, Vector4 t)
        {
            var l = Lerp(a, b, t);
            var r = Lerp(b, c, t);
            return Lerp(l, r, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 CLerp(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t)
        {
            var l = QLerp(a, b, c, t);
            var r = QLerp(b, c, d, t);
            return Lerp(l, r, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 CLerp(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 t)
        {
            var l = QLerp(a, b, c, t);
            var r = QLerp(b, c, d, t);
            return Lerp(l, r, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 CLerp(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float t)
        {
            var l = QLerp(a, b, c, t);
            var r = QLerp(b, c, d, t);
            return Lerp(l, r, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 CLerp(Vector3 a, Vector3 b, Vector3 c, Vector3 d, Vector3 t)
        {
            var l = QLerp(a, b, c, t);
            var r = QLerp(b, c, d, t);
            return Lerp(l, r, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 CLerp(Vector4 a, Vector4 b, Vector4 c, Vector4 d, float t)
        {
            var l = QLerp(a, b, c, t);
            var r = QLerp(b, c, d, t);
            return Lerp(l, r, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 CLerp(Vector4 a, Vector4 b, Vector4 c, Vector4 d, Vector4 t)
        {
            var l = QLerp(a, b, c, t);
            var r = QLerp(b, c, d, t);
            return Lerp(l, r, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Unlerp(Vector2 a, Vector2 b, Vector2 v)
        {
            var ab = b - a;
            var av = v - a;
            return Vector2.Dot(av, ab) / Vector2.Dot(ab, ab);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Unlerp(Vector2 a, Vector2 b, float t)
        {
            a.x = Unlerp(a.x, b.x, t);
            a.y = Unlerp(a.y, b.y, t);
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Unlerp(Vector3 a, Vector3 b, Vector3 v)
        {
            var ab = b - a;
            var av = v - a;
            return Vector3.Dot(av, ab) / Vector3.Dot(ab, ab);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Unlerp(Vector3 a, Vector3 b, float t)
        {
            a.x = Unlerp(a.x, b.x, t);
            a.y = Unlerp(a.y, b.y, t);
            a.z = Unlerp(a.z, b.z, t);
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Unlerp(Vector4 a, Vector4 b, Vector4 v)
        {
            var ab = b - a;
            var av = v - a;
            return Vector4.Dot(av, ab) / Vector4.Dot(ab, ab);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Unlerp(Vector4 a, Vector4 b, float t)
        {
            a.x = Unlerp(a.x, b.x, t);
            a.y = Unlerp(a.y, b.y, t);
            a.z = Unlerp(a.z, b.z, t);
            a.w = Unlerp(a.w, b.w, t);
            return a;
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
            v.x = Mathf.Clamp(v.x, min.x, max.x);
            v.y = Mathf.Clamp(v.y, min.y, max.y);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Clamp(Vector2 v, float min, Vector2 max)
        {
            v.x = Mathf.Clamp(v.x, min, max.x);
            v.y = Mathf.Clamp(v.y, min, max.y);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Clamp(Vector2 v, Vector2 min, float max)
        {
            v.x = Mathf.Clamp(v.x, min.x, max);
            v.y = Mathf.Clamp(v.y, min.y, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Clamp(Vector2 v, float min, float max)
        {
            v.x = Mathf.Clamp(v.x, min, max);
            v.y = Mathf.Clamp(v.y, min, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Clamp(Vector3 v, Vector3 min, Vector3 max)
        {
            v.x = Mathf.Clamp(v.x, min.x, max.x);
            v.y = Mathf.Clamp(v.y, min.y, max.y);
            v.z = Mathf.Clamp(v.z, min.z, max.z);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Clamp(Vector3 v, float min, Vector3 max)
        {
            v.x = Mathf.Clamp(v.x, min, max.x);
            v.y = Mathf.Clamp(v.y, min, max.y);
            v.z = Mathf.Clamp(v.z, min, max.z);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Clamp(Vector3 v, Vector3 min, float max)
        {
            v.x = Mathf.Clamp(v.x, min.x, max);
            v.y = Mathf.Clamp(v.y, min.y, max);
            v.z = Mathf.Clamp(v.z, min.z, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Clamp(Vector3 v, float min, float max)
        {
            v.x = Mathf.Clamp(v.x, min, max);
            v.y = Mathf.Clamp(v.y, min, max);
            v.z = Mathf.Clamp(v.z, min, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Clamp(Vector4 v, Vector4 min, Vector4 max)
        {
            v.x = Mathf.Clamp(v.x, min.x, max.x);
            v.y = Mathf.Clamp(v.y, min.y, max.y);
            v.z = Mathf.Clamp(v.z, min.z, max.z);
            v.w = Mathf.Clamp(v.w, min.w, max.w);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Clamp(Vector4 v, float min, Vector4 max)
        {
            v.x = Mathf.Clamp(v.x, min, max.x);
            v.y = Mathf.Clamp(v.y, min, max.y);
            v.z = Mathf.Clamp(v.z, min, max.z);
            v.w = Mathf.Clamp(v.w, min, max.w);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Clamp(Vector4 v, Vector4 min, float max)
        {
            v.x = Mathf.Clamp(v.x, min.x, max);
            v.y = Mathf.Clamp(v.y, min.y, max);
            v.z = Mathf.Clamp(v.z, min.z, max);
            v.w = Mathf.Clamp(v.w, min.w, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Clamp(Vector4 v, float min, float max)
        {
            v.x = Mathf.Clamp(v.x, min, max);
            v.y = Mathf.Clamp(v.y, min, max);
            v.z = Mathf.Clamp(v.z, min, max);
            v.w = Mathf.Clamp(v.w, min, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Clamp(Vector2Int v, Vector2Int min, Vector2Int max)
        {
            v.x = Mathf.Clamp(v.x, min.x, max.x);
            v.y = Mathf.Clamp(v.y, min.y, max.y);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Clamp(Vector2Int v, int min, Vector2Int max)
        {
            v.x = Mathf.Clamp(v.x, min, max.x);
            v.y = Mathf.Clamp(v.y, min, max.y);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Clamp(Vector2Int v, Vector2Int min, int max)
        {
            v.x = Mathf.Clamp(v.x, min.x, max);
            v.y = Mathf.Clamp(v.y, min.y, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Clamp(Vector2Int v, int min, int max)
        {
            v.x = Mathf.Clamp(v.x, min, max);
            v.y = Mathf.Clamp(v.y, min, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Clamp(Vector3Int v, Vector3Int min, Vector3Int max)
        {
            v.x = Mathf.Clamp(v.x, min.x, max.x);
            v.y = Mathf.Clamp(v.y, min.y, max.y);
            v.z = Mathf.Clamp(v.z, min.z, max.z);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Clamp(Vector3Int v, int min, Vector3Int max)
        {
            v.x = Mathf.Clamp(v.x, min, max.x);
            v.y = Mathf.Clamp(v.y, min, max.y);
            v.z = Mathf.Clamp(v.z, min, max.z);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Clamp(Vector3Int v, Vector3Int min, int max)
        {
            v.x = Mathf.Clamp(v.x, min.x, max);
            v.y = Mathf.Clamp(v.y, min.y, max);
            v.z = Mathf.Clamp(v.z, min.z, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Clamp(Vector3Int v, int min, int max)
        {
            v.x = Mathf.Clamp(v.x, min, max);
            v.y = Mathf.Clamp(v.y, min, max);
            v.z = Mathf.Clamp(v.z, min, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Sign(Vector2 v)
        {
            return new Vector2Int(
                Sign(v.x),
                Sign(v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Sign(Vector3 v)
        {
            return new Vector3Int(
                Sign(v.x),
                Sign(v.y),
                Sign(v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Wrap(Vector2 v, Vector2 min, Vector2 max)
        {
            v.x = Wrap(v.x, min.x, max.x);
            v.y = Wrap(v.y, min.y, max.y);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Wrap(Vector2 v, float min, Vector2 max)
        {
            v.x = Wrap(v.x, min, max.x);
            v.y = Wrap(v.y, min, max.y);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Wrap(Vector2 v, Vector2 min, float max)
        {
            v.x = Wrap(v.x, min.x, max);
            v.y = Wrap(v.y, min.y, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Wrap(Vector2 v, float min, float max)
        {
            v.x = Wrap(v.x, min, max);
            v.y = Wrap(v.y, min, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Wrap(Vector3 v, Vector3 min, Vector3 max)
        {
            v.x = Wrap(v.x, min.x, max.x);
            v.y = Wrap(v.y, min.y, max.y);
            v.z = Wrap(v.z, min.z, max.z);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Wrap(Vector3 v, float min, Vector3 max)
        {
            v.x = Wrap(v.x, min, max.x);
            v.y = Wrap(v.y, min, max.y);
            v.z = Wrap(v.z, min, max.z);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Wrap(Vector3 v, Vector3 min, float max)
        {
            v.x = Wrap(v.x, min.x, max);
            v.y = Wrap(v.y, min.y, max);
            v.z = Wrap(v.z, min.z, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Wrap(Vector3 v, float min, float max)
        {
            v.x = Wrap(v.x, min, max);
            v.y = Wrap(v.y, min, max);
            v.z = Wrap(v.z, min, max);
            return v;
        }

        public static Vector4 Wrap(Vector4 v, Vector4 min, Vector4 max)
        {
            v.x = Wrap(v.x, min.x, max.x);
            v.y = Wrap(v.y, min.y, max.y);
            v.z = Wrap(v.z, min.z, max.z);
            v.w = Wrap(v.w, min.w, max.w);
            return v;
        }

        public static Vector4 Wrap(Vector4 v, float min, Vector4 max)
        {
            v.x = Wrap(v.x, min, max.x);
            v.y = Wrap(v.y, min, max.y);
            v.z = Wrap(v.z, min, max.z);
            v.w = Wrap(v.w, min, max.w);
            return v;
        }

        public static Vector4 Wrap(Vector4 v, Vector4 min, float max)
        {
            v.x = Wrap(v.x, min.x, max);
            v.y = Wrap(v.y, min.y, max);
            v.z = Wrap(v.z, min.z, max);
            v.w = Wrap(v.w, min.w, max);
            return v;
        }

        public static Vector4 Wrap(Vector4 v, float min, float max)
        {
            v.x = Wrap(v.x, min, max);
            v.y = Wrap(v.y, min, max);
            v.z = Wrap(v.z, min, max);
            v.w = Wrap(v.w, min, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Wrap(Vector2Int v, Vector2Int min, Vector2Int max)
        {
            v.x = Wrap(v.x, min.x, max.x);
            v.y = Wrap(v.y, min.y, max.y);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Wrap(Vector2Int v, int min, Vector2Int max)
        {
            v.x = Wrap(v.x, min, max.x);
            v.y = Wrap(v.y, min, max.y);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Wrap(Vector2Int v, Vector2Int min, int max)
        {
            v.x = Wrap(v.x, min.x, max);
            v.y = Wrap(v.y, min.y, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Wrap(Vector2Int v, int min, int max)
        {
            v.x = Wrap(v.x, min, max);
            v.y = Wrap(v.y, min, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Wrap(Vector3Int v, Vector3Int min, Vector3Int max)
        {
            v.x = Wrap(v.x, min.x, max.x);
            v.y = Wrap(v.y, min.y, max.y);
            v.z = Wrap(v.z, min.z, max.z);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Wrap(Vector3Int v, int min, Vector3Int max)
        {
            v.x = Wrap(v.x, min, max.x);
            v.y = Wrap(v.y, min, max.y);
            v.z = Wrap(v.z, min, max.z);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Wrap(Vector3Int v, Vector3Int min, int max)
        {
            v.x = Wrap(v.x, min.x, max);
            v.y = Wrap(v.y, min.y, max);
            v.z = Wrap(v.z, min.z, max);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Wrap(Vector3Int v, int min, int max)
        {
            v.x = Wrap(v.x, min, max);
            v.y = Wrap(v.y, min, max);
            v.z = Wrap(v.z, min, max);
            return v;
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
        public static Vector2 SmoothStep(Vector2 a, Vector2 b, float t)
        {
            return Lerp(a, b, SmoothStep(t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 SmoothStep(Vector2 a, Vector2 b, Vector2 t)
        {
            return Lerp(a, b, SmoothStep(t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 SmoothStep(Vector3 a, Vector3 b, float t)
        {
            return Lerp(a, b, SmoothStep(t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 SmoothStep(Vector3 a, Vector3 b, Vector3 t)
        {
            return Lerp(a, b, SmoothStep(t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 SmoothStep(Vector4 a, Vector4 b, float t)
        {
            return Lerp(a, b, SmoothStep(t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 SmoothStep(Vector4 a, Vector4 b, Vector4 t)
        {
            return Lerp(a, b, SmoothStep(t));
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
        public static Vector2 SmootherStep(Vector2 a, Vector2 b, float t)
        {
            return Lerp(a, b, SmootherStep(t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 SmootherStep(Vector2 a, Vector2 b, Vector2 t)
        {
            return Lerp(a, b, SmootherStep(t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 SmootherStep(Vector3 a, Vector3 b, float t)
        {
            return Lerp(a, b, SmootherStep(t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 SmootherStep(Vector3 a, Vector3 b, Vector3 t)
        {
            return Lerp(a, b, SmootherStep(t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 SmootherStep(Vector4 a, Vector4 b, float t)
        {
            return Lerp(a, b, SmootherStep(t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 SmootherStep(Vector4 a, Vector4 b, Vector4 t)
        {
            return Lerp(a, b, SmootherStep(t));
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
            return Reciprocal(Vector2.Max(v, Vector2.one * kEpsilon));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ReciprocalSafe(Vector3 v)
        {
            return Reciprocal(Vector3.Max(v, Vector3.one * kEpsilon));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 ReciprocalSafe(Vector4 v)
        {
            return Reciprocal(Vector4.Max(v, Vector4.one * kEpsilon));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Round(Vector2 v, int d)
        {
            v.x = Round(v.x, d);
            v.y = Round(v.y, d);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Round(Vector3 v, int d)
        {
            v.x = Round(v.x, d);
            v.y = Round(v.y, d);
            v.z = Round(v.z, d);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Round(Vector4 v, int d)
        {
            v.x = Round(v.x, d);
            v.y = Round(v.y, d);
            v.z = Round(v.z, d);
            v.w = Round(v.w, d);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Round(Vector2 v)
        {
            v.x = Mathf.Round(v.x);
            v.y = Mathf.Round(v.y);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Round(Vector3 v)
        {
            v.x = Mathf.Round(v.x);
            v.y = Mathf.Round(v.y);
            v.z = Mathf.Round(v.z);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Round(Vector4 v)
        {
            v.x = Mathf.Round(v.x);
            v.y = Mathf.Round(v.y);
            v.z = Mathf.Round(v.z);
            v.w = Mathf.Round(v.w);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Floor(Vector2 v)
        {
            v.x = Mathf.Floor(v.x);
            v.y = Mathf.Floor(v.y);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Floor(Vector3 v)
        {
            v.x = Mathf.Floor(v.x);
            v.y = Mathf.Floor(v.y);
            v.z = Mathf.Floor(v.z);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Floor(Vector4 v)
        {
            v.x = Mathf.Floor(v.x);
            v.y = Mathf.Floor(v.y);
            v.z = Mathf.Floor(v.z);
            v.w = Mathf.Floor(v.w);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Ceil(Vector2 v)
        {
            v.x = Mathf.Ceil(v.x);
            v.y = Mathf.Ceil(v.y);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Ceil(Vector3 v)
        {
            v.x = Mathf.Ceil(v.x);
            v.y = Mathf.Ceil(v.y);
            v.z = Mathf.Ceil(v.z);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Ceil(Vector4 v)
        {
            v.x = Mathf.Ceil(v.x);
            v.y = Mathf.Ceil(v.y);
            v.z = Mathf.Ceil(v.z);
            v.w = Mathf.Ceil(v.w);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int CastToInt(Vector2 v)
        {
            Vector2Int r = Vector2Int.zero;
            r.x = (int)v.x;
            r.y = (int)v.y;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int CastToInt(Vector3 v)
        {
            Vector3Int r = Vector3Int.zero;
            r.x = (int)v.x;
            r.y = (int)v.y;
            r.z = (int)v.z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int RoundToInt(Vector2 v)
        {
            Vector2Int r = Vector2Int.zero;
            r.x = Mathf.RoundToInt(v.x);
            r.y = Mathf.RoundToInt(v.y);
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int RoundToInt(Vector3 v)
        {
            Vector3Int r = Vector3Int.zero;
            r.x = Mathf.RoundToInt(v.x);
            r.y = Mathf.RoundToInt(v.y);
            r.z = Mathf.RoundToInt(v.z);
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int FloorToInt(Vector2 v)
        {
            Vector2Int r = Vector2Int.zero;
            r.x = Mathf.FloorToInt(v.x);
            r.y = Mathf.FloorToInt(v.y);
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int FloorToInt(Vector3 v)
        {
            Vector3Int r = Vector3Int.zero;
            r.x = Mathf.FloorToInt(v.x);
            r.y = Mathf.FloorToInt(v.y);
            r.z = Mathf.FloorToInt(v.z);
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int CeilToInt(Vector2 v)
        {
            Vector2Int r = Vector2Int.zero;
            r.x = Mathf.CeilToInt(v.x);
            r.y = Mathf.CeilToInt(v.y);
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int CeilToInt(Vector3 v)
        {
            Vector3Int r = Vector3Int.zero;
            r.x = Mathf.CeilToInt(v.x);
            r.y = Mathf.CeilToInt(v.y);
            r.z = Mathf.CeilToInt(v.z);
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 RoundTo(Vector2 v, float s)
        {
            v.x = Mathf.Round(v.x / s) * s;
            v.y = Mathf.Round(v.y / s) * s;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 RoundTo(Vector2 v, Vector2 s)
        {
            v.x = Mathf.Round(v.x / s.x) * s.x;
            v.y = Mathf.Round(v.y / s.y) * s.y;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 RoundTo(Vector3 v, float s)
        {
            v.x = Mathf.Round(v.x / s) * s;
            v.y = Mathf.Round(v.y / s) * s;
            v.z = Mathf.Round(v.z / s) * s;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 RoundTo(Vector3 v, Vector3 s)
        {
            v.x = Mathf.Round(v.x / s.x) * s.x;
            v.y = Mathf.Round(v.y / s.y) * s.y;
            v.z = Mathf.Round(v.z / s.z) * s.z;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 RoundTo(Vector4 v, float s)
        {
            v.x = Mathf.Round(v.x / s) * s;
            v.y = Mathf.Round(v.y / s) * s;
            v.z = Mathf.Round(v.z / s) * s;
            v.w = Mathf.Round(v.w / s) * s;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 RoundTo(Vector4 v, Vector4 s)
        {
            v.x = Mathf.Round(v.x / s.x) * s.x;
            v.y = Mathf.Round(v.y / s.y) * s.y;
            v.z = Mathf.Round(v.z / s.z) * s.z;
            v.w = Mathf.Round(v.w / s.w) * s.w;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Abs(Vector2 v)
        {
            v.x = Mathf.Abs(v.x);
            v.y = Mathf.Abs(v.y);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Abs(Vector3 v)
        {
            v.x = Mathf.Abs(v.x);
            v.y = Mathf.Abs(v.y);
            v.z = Mathf.Abs(v.z);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Abs(Vector4 v)
        {
            v.x = Mathf.Abs(v.x);
            v.y = Mathf.Abs(v.y);
            v.z = Mathf.Abs(v.z);
            v.w = Mathf.Abs(v.w);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Abs(Vector2Int v)
        {
            v.x = Mathf.Abs(v.x);
            v.y = Mathf.Abs(v.y);
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Abs(Vector3Int v)
        {
            v.x = Mathf.Abs(v.x);
            v.y = Mathf.Abs(v.y);
            v.z = Mathf.Abs(v.z);
            return v;
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
            a.x = Select(a.x, b.x, c.x);
            a.y = Select(a.y, b.y, c.y);
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Select(Vector3 a, Vector3 b, Bool3 c)
        {
            a.x = Select(a.x, b.x, c.x);
            a.y = Select(a.y, b.y, c.y);
            a.z = Select(a.z, b.z, c.z);
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Select(Vector4 a, Vector4 b, Bool4 c)
        {
            a.x = Select(a.x, b.x, c.x);
            a.y = Select(a.y, b.y, c.y);
            a.z = Select(a.z, b.z, c.z);
            a.w = Select(a.w, b.w, c.w);
            return a;
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
            a.x = Select(a.x, b.x, c.x);
            a.y = Select(a.y, b.y, c.y);
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Select(Vector3Int a, Vector3Int b, Bool3 c)
        {
            a.x = Select(a.x, b.x, c.x);
            a.y = Select(a.y, b.y, c.y);
            a.z = Select(a.z, b.z, c.z);
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Step(Vector2 a, Vector2 b)
        {
            a.x = Step(a.x, b.x);
            a.y = Step(a.y, b.y);
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Step(Vector3 a, Vector3 b)
        {
            a.x = Step(a.x, b.x);
            a.y = Step(a.y, b.y);
            a.z = Step(a.z, b.z);
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Step(Vector4 a, Vector4 b)
        {
            a.x = Step(a.x, b.x);
            a.y = Step(a.y, b.y);
            a.z = Step(a.z, b.z);
            a.w = Step(a.w, b.w);
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Step(Vector2Int a, Vector2Int b)
        {
            a.x = Step(a.x, b.x);
            a.y = Step(a.y, b.y);
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Step(Vector3Int a, Vector3Int b)
        {
            a.x = Step(a.x, b.x);
            a.y = Step(a.y, b.y);
            a.z = Step(a.z, b.z);
            return a;
        }

        /// <summary> Returns the componentwise fractional part of a Vector2 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Frac(Vector2 f)
        {
            return Sub(f, Floor(f));
        }

        /// <summary> Returns the componentwise fractional part of a Vector3 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Frac(Vector3 f)
        {
            return Sub(f, Floor(f));
        }

        /// <summary> Returns the componentwise fractional part of a Vector4 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Frac(Vector4 f)
        {
            return Sub(f, Floor(f));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mod(Vector2 v, Vector2 m)
        {
            return Sub(v, Mul(Floor(Mul(v, Div(1.0f, m))), m));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mod(Vector3 v, Vector3 m)
        {
            return Sub(v, Mul(Floor(Mul(v, Div(1.0f, m))), m));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Mod(Vector4 v, Vector4 m)
        {
            return Sub(v, Mul(Floor(Mul(v, Div(1.0f, m))), m));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mod(Vector2 v, float m)
        {
            return Sub(v, Mul(Floor(Mul(v, 1.0f / m)), m));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mod(Vector3 v, float m)
        {
            return Sub(v, Mul(Floor(Mul(v, 1.0f / m)), m));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Mod(Vector4 v, float m)
        {
            return Sub(v, Mul(Floor(Mul(v, 1.0f / m)), m));
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
            a.x = Mathf.Min(a.x, b.x);
            a.y = Mathf.Min(a.y, b.y);
            return a;
        }

        /// <summary> Returns the componentwise minimum of three Vector2 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Min(Vector2 a, Vector2 b, Vector2 c)
        {
            a.x = Mathf.Min(a.x, Mathf.Min(b.x, c.x));
            a.y = Mathf.Min(a.y, Mathf.Min(b.y, c.y));
            return a;
        }

        /// <summary> Returns the componentwise minimum of a Vector2 array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Min(params Vector2[] vs)
        {
            var r = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                r = Min(r, vs[i]);
            return r;
        }

        /// <summary> Returns the componentwise minimum of a Vector2 vector and a float value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Min(Vector2 v, float f)
        {
            v.x = Mathf.Min(v.x, f);
            v.y = Mathf.Min(v.y, f);
            return v;
        }

        /// <summary> Returns the componentwise minimum of a float value and a Vector2 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Min(float f, Vector2 v)
        {
            v.x = Mathf.Min(f, v.x);
            v.y = Mathf.Min(f, v.y);
            return v;
        }

        /// <summary> Returns the componentwise minimum of two Vector3 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Min(Vector3 a, Vector3 b)
        {
            a.x = Mathf.Min(a.x, b.x);
            a.y = Mathf.Min(a.y, b.y);
            a.z = Mathf.Min(a.z, b.z);
            return a;
        }

        /// <summary> Returns the componentwise minimum of three Vector3 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Min(Vector3 a, Vector3 b, Vector3 c)
        {
            a.x = Mathf.Min(a.x, Mathf.Min(b.x, c.x));
            a.y = Mathf.Min(a.y, Mathf.Min(b.y, c.y));
            a.z = Mathf.Min(a.z, Mathf.Min(b.z, c.z));
            return a;
        }

        /// <summary> Returns the componentwise minimum of an Vector3 array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Min(params Vector3[] vs)
        {
            var r = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                r = Min(r, vs[i]);
            return r;
        }

        /// <summary> Returns the componentwise minimum of a Vector3 vector and a float value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Min(Vector3 v, float f)
        {
            v.x = Mathf.Min(v.x, f);
            v.y = Mathf.Min(v.y, f);
            v.z = Mathf.Min(v.z, f);
            return v;
        }

        /// <summary> Returns the componentwise minimum of a float value and a Vector3 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Min(float f, Vector3 v)
        {
            v.x = Mathf.Min(f, v.x);
            v.y = Mathf.Min(f, v.y);
            v.z = Mathf.Min(f, v.z);
            return v;
        }

        /// <summary> Returns the componentwise minimum of two Vector4 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Min(Vector4 a, Vector4 b)
        {
            a.x = Mathf.Min(a.x, b.x);
            a.y = Mathf.Min(a.y, b.y);
            a.z = Mathf.Min(a.z, b.z);
            a.w = Mathf.Min(a.w, b.w);
            return a;
        }

        /// <summary> Returns the componentwise minimum of three Vector4 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Min(Vector4 a, Vector4 b, Vector4 c)
        {
            a.x = Mathf.Min(a.x, Mathf.Min(b.x, c.x));
            a.y = Mathf.Min(a.y, Mathf.Min(b.y, c.y));
            a.z = Mathf.Min(a.z, Mathf.Min(b.z, c.z));
            a.w = Mathf.Min(a.w, Mathf.Min(b.w, c.w));
            return a;
        }

        /// <summary> Returns the componentwise minimum of an Vector4 array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Min(params Vector4[] vs)
        {
            var r = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                r = Min(r, vs[i]);
            return r;
        }

        /// <summary> Returns the componentwise minimum of a Vector4 vector and a float value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Min(Vector4 v, float f)
        {
            v.x = Mathf.Min(v.x, f);
            v.y = Mathf.Min(v.y, f);
            v.z = Mathf.Min(v.z, f);
            v.w = Mathf.Min(v.w, f);
            return v;
        }

        /// <summary> Returns the componentwise minimum of a float value and a Vector4 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Min(float f, Vector4 v)
        {
            v.x = Mathf.Min(f, v.x);
            v.y = Mathf.Min(f, v.y);
            v.z = Mathf.Min(f, v.z);
            v.w = Mathf.Min(f, v.w);
            return v;
        }

        /// <summary> Returns the componentwise minimum of two Vector2Int vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Min(Vector2Int a, Vector2Int b)
        {
            a.x = Mathf.Min(a.x, b.x);
            a.y = Mathf.Min(a.y, b.y);
            return a;
        }

        /// <summary> Returns the componentwise minimum of three Vector2Int vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Min(Vector2Int a, Vector2Int b, Vector2Int c)
        {
            a.x = Mathf.Min(a.x, Mathf.Min(b.x, c.x));
            a.y = Mathf.Min(a.y, Mathf.Min(b.y, c.y));
            return a;
        }

        /// <summary> Returns the componentwise minimum of an Vector2Int array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Min(params Vector2Int[] vs)
        {
            var r = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                r = Min(r, vs[i]);
            return r;
        }

        /// <summary> Returns the componentwise minimum of a Vector2Int vector and an int value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Min(Vector2Int v, int i)
        {
            v.x = Mathf.Min(v.x, i);
            v.y = Mathf.Min(v.y, i);
            return v;
        }

        /// <summary> Returns the componentwise minimum of an int value and a Vector2Int vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Min(int i, Vector2Int v)
        {
            v.x = Mathf.Min(i, v.x);
            v.y = Mathf.Min(i, v.y);
            return v;
        }

        /// <summary> Returns the componentwise minimum of two Vector3Int vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Min(Vector3Int a, Vector3Int b)
        {
            a.x = Mathf.Min(a.x, b.x);
            a.y = Mathf.Min(a.y, b.y);
            a.z = Mathf.Min(a.z, b.z);
            return a;
        }

        /// <summary> Returns the componentwise minimum of three Vector3Int vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Min(Vector3Int a, Vector3Int b, Vector3Int c)
        {
            a.x = Mathf.Min(a.x, Mathf.Min(b.x, c.x));
            a.y = Mathf.Min(a.y, Mathf.Min(b.y, c.y));
            a.z = Mathf.Min(a.z, Mathf.Min(b.z, c.z));
            return a;
        }

        /// <summary> Returns the componentwise minimum of an Vector3Int array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Min(params Vector3Int[] vs)
        {
            var r = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                r = Min(r, vs[i]);
            return r;
        }

        /// <summary> Returns the componentwise minimum of a Vector3Int vector and an int value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Min(Vector3Int v, int i)
        {
            v.x = Mathf.Min(v.x, i);
            v.y = Mathf.Min(v.y, i);
            v.z = Mathf.Min(v.z, i);
            return v;
        }

        /// <summary> Returns the componentwise minimum of an int value and a Vector3Int vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Min(int i, Vector3Int v)
        {
            v.x = Mathf.Min(i, v.x);
            v.y = Mathf.Min(i, v.y);
            v.z = Mathf.Min(i, v.z);
            return v;
        }

        /// <summary> Returns the componentwise maximum of two Vector2 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Max(Vector2 a, Vector2 b)
        {
            a.x = Mathf.Max(a.x, b.x);
            a.y = Mathf.Max(a.y, b.y);
            return a;
        }

        /// <summary> Returns the componentwise maximum of three Vector2 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Max(Vector2 a, Vector2 b, Vector2 c)
        {
            a.x = Mathf.Max(a.x, Mathf.Max(b.x, c.x));
            a.y = Mathf.Max(a.y, Mathf.Max(b.y, c.y));
            return a;
        }

        /// <summary> Returns the componentwise maximum of an Vector2 array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Max(params Vector2[] vs)
        {
            var r = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                r = Max(r, vs[i]);
            return r;
        }

        /// <summary> Returns the componentwise maximum of a Vector2 vector and a float value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Max(Vector2 v, float f)
        {
            v.x = Mathf.Max(v.x, f);
            v.y = Mathf.Max(v.y, f);
            return v;
        }

        /// <summary> Returns the componentwise maximum of a float value and a Vector2 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Max(float f, Vector2 v)
        {
            v.x = Mathf.Max(f, v.x);
            v.y = Mathf.Max(f, v.y);
            return v;
        }

        /// <summary> Returns the componentwise maximum of two Vector3 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Max(Vector3 a, Vector3 b)
        {
            a.x = Mathf.Max(a.x, b.x);
            a.y = Mathf.Max(a.y, b.y);
            a.z = Mathf.Max(a.z, b.z);
            return a;
        }

        /// <summary> Returns the componentwise maximum of three Vector3 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Max(Vector3 a, Vector3 b, Vector3 c)
        {
            a.x = Mathf.Max(a.x, Mathf.Max(b.x, c.x));
            a.y = Mathf.Max(a.y, Mathf.Max(b.y, c.y));
            a.z = Mathf.Max(a.z, Mathf.Max(b.z, c.z));
            return a;
        }

        /// <summary> Returns the componentwise maximum of an Vector3 array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Max(params Vector3[] vs)
        {
            var r = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                r = Max(r, vs[i]);
            return r;
        }

        /// <summary> Returns the componentwise maximum of a Vector3 vector and a float value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Max(Vector3 v, float f)
        {
            v.x = Mathf.Max(v.x, f);
            v.y = Mathf.Max(v.y, f);
            v.z = Mathf.Max(v.z, f);
            return v;
        }

        /// <summary> Returns the componentwise maximum of a float value and a Vector3 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Max(float f, Vector3 v)
        {
            v.x = Mathf.Max(f, v.x);
            v.y = Mathf.Max(f, v.y);
            v.z = Mathf.Max(f, v.z);
            return v;
        }

        /// <summary> Returns the componentwise maximum of two Vector4 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Max(Vector4 a, Vector4 b)
        {
            a.x = Mathf.Max(a.x, b.x);
            a.y = Mathf.Max(a.y, b.y);
            a.z = Mathf.Max(a.z, b.z);
            a.w = Mathf.Max(a.w, b.w);
            return a;
        }

        /// <summary> Returns the componentwise maximum of three Vector4 vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Max(Vector4 a, Vector4 b, Vector4 c)
        {
            a.x = Mathf.Max(a.x, Mathf.Max(b.x, c.x));
            a.y = Mathf.Max(a.y, Mathf.Max(b.y, c.y));
            a.z = Mathf.Max(a.z, Mathf.Max(b.z, c.z));
            a.w = Mathf.Max(a.w, Mathf.Max(b.w, c.w));
            return a;
        }

        /// <summary> Returns the componentwise maximum of an Vector4 array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Max(params Vector4[] vs)
        {
            var r = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                r = Max(r, vs[i]);
            return r;
        }

        /// <summary> Returns the componentwise maximum of a Vector4 vector and a float value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Max(Vector4 v, float f)
        {
            v.x = Mathf.Max(v.x, f);
            v.y = Mathf.Max(v.y, f);
            v.z = Mathf.Max(v.z, f);
            v.w = Mathf.Max(v.w, f);
            return v;
        }

        /// <summary> Returns the componentwise maximum of a float value and a Vector4 vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Max(float f, Vector4 v)
        {
            v.x = Mathf.Max(f, v.x);
            v.y = Mathf.Max(f, v.y);
            v.z = Mathf.Max(f, v.z);
            v.w = Mathf.Max(f, v.w);
            return v;
        }

        /// <summary> Returns the componentwise maximum of two Vector2Int vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Max(Vector2Int a, Vector2Int b)
        {
            a.x = Mathf.Max(a.x, b.x);
            a.y = Mathf.Max(a.y, b.y);
            return a;
        }

        /// <summary> Returns the componentwise maximum of three Vector2Int vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Max(Vector2Int a, Vector2Int b, Vector2Int c)
        {
            a.x = Mathf.Max(a.x, Mathf.Max(b.x, c.x));
            a.y = Mathf.Max(a.y, Mathf.Max(b.y, c.y));
            return a;
        }

        /// <summary> Returns the componentwise maximum of an Vector2Int array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Max(params Vector2Int[] vs)
        {
            var r = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                r = Max(r, vs[i]);
            return r;
        }

        /// <summary> Returns the componentwise maximum of a Vector2Int vector and an int value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Max(Vector2Int v, int i)
        {
            v.x = Mathf.Max(v.x, i);
            v.y = Mathf.Max(v.y, i);
            return v;
        }

        /// <summary> Returns the componentwise maximum of an int value and a Vector2Int vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Max(int i, Vector2Int v)
        {
            v.x = Mathf.Max(i, v.x);
            v.y = Mathf.Max(i, v.y);
            return v;
        }

        /// <summary> Returns the componentwise maximum of two Vector3Int vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Max(Vector3Int a, Vector3Int b)
        {
            a.x = Mathf.Max(a.x, b.x);
            a.y = Mathf.Max(a.y, b.y);
            a.z = Mathf.Max(a.z, b.z);
            return a;
        }

        /// <summary> Returns the componentwise maximum of three Vector3Int vectors </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Max(Vector3Int a, Vector3Int b, Vector3Int c)
        {
            a.x = Mathf.Max(a.x, Mathf.Max(b.x, c.x));
            a.y = Mathf.Max(a.y, Mathf.Max(b.y, c.y));
            a.z = Mathf.Max(a.z, Mathf.Max(b.z, c.z));
            return a;
        }

        /// <summary> Returns the componentwise maximum of an Vector3Int array </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Max(params Vector3Int[] vs)
        {
            var r = vs[0];
            for (int i = 1; i < vs.Length; ++i)
                r = Max(r, vs[i]);
            return r;
        }

        /// <summary> Returns the componentwise maximum of a Vector3Int vector and an int value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Max(Vector3Int v, int i)
        {
            v.x = Mathf.Max(v.x, i);
            v.y = Mathf.Max(v.y, i);
            v.z = Mathf.Max(v.z, i);
            return v;
        }

        /// <summary> Returns the componentwise maximum of an int value and a Vector3Int vector </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Max(int i, Vector3Int v)
        {
            v.x = Mathf.Max(i, v.x);
            v.y = Mathf.Max(i, v.y);
            v.z = Mathf.Max(i, v.z);
            return v;
        }

        /// <summary> Returns a normalized Vector2 value based on radial angle a </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 ToUnitVector(float a)
        {
            Vector2 r;
            r.x = (float)Math.Sin(a);
            r.y = (float)Math.Cos(a);
            return r;
        }

        /// <summary> Returns a radial angle from normalized Vector2 v </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToAngle(Vector2 v)
        {
            return (float)Math.Atan2(v.x, v.y);
        }

        /// <summary> Returns projection of vector 'v' onto normal vector 'n' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Project(Vector2 v, Vector2 n)
        {
            var vdotn = Vector2.Dot(v, n);
            var ndotn = Vector2.Dot(n, n);
            return Mul(n, vdotn / ndotn);
        }

        /// <summary> Returns projection of vector 'v' onto normal vector 'n' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Project(Vector3 v, Vector3 n)
        {
            var vdotn = Vector3.Dot(v, n);
            var ndotn = Vector3.Dot(n, n);
            return Mul(n, vdotn / ndotn);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Rotate(Vector2 point, float angle)
        {
            Vector2 r;
            float sin = Mathf.Sin(angle);
            float cos = Mathf.Cos(angle);
            r.x = (cos * point.x) - (sin * point.y);
            r.y = (sin * point.x) + (cos * point.y);
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Rotate(Vector3 point, Quaternion rotation)
        {
            return rotation * point;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 RotateAround(Vector2 point, Vector2 pivot, float angle)
        {
            return Add(Rotate(Sub(point, pivot), angle), pivot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 RotateAround(Vector3 point, Vector3 pivot, Quaternion rotation)
        {
            return Add(rotation * Sub(point, pivot), pivot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Transform(Vector2 point, Vector2 translation, float rotation, Vector2 scale)
        {
            return Add(Rotate(Mul(point, scale), rotation), translation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Transform(Vector2[] points, Vector2 translation, float rotation, Vector2 scale)
        {
            for (int i = 0; i < points.Length; ++i)
                points[i] = Transform(points[i], translation, rotation, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 InverseTransform(Vector2 point, Vector2 translation, float angle, Vector2 scale)
        {
            return Mul(Rotate(Sub(point, translation), -angle), Reciprocal(scale));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Transform(Vector3 point, Vector3 translation, Quaternion rotation, Vector3 scale)
        {
            return Rotate(Mul(point, scale), rotation) + translation;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Transform(Vector3[] points, Vector3 translation, Quaternion rotation, Vector3 scale)
        {
            for (int i = 0; i < points.Length; ++i)
                points[i] = Transform(points[i], translation, rotation, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 InverseTransform(Vector3 point, Vector3 translation, Quaternion rotation, Vector3 scale)
        {
            return Mul(Rotate(Sub(point, translation), Quaternion.Inverse(rotation)), Reciprocal(scale));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Average(params Vector2[] vs)
        {
            var r = Vector2.zero;
            for (int i = 0; i < vs.Length; ++i)
                r = Add(r, vs[i]);
            return Div(r, vs.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Average(params Vector3[] vs)
        {
            var r = Vector3.zero;
            for (int i = 0; i < vs.Length; ++i)
                r = Add(r, vs[i]);
            return Div(r, vs.Length);
        }
    }
}
