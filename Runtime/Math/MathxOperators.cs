using Common.Extensions;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static partial class Mathx
    {
        #region COMPARE
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CompareTo(Vector2 a, Vector2 b)
        {
            int result = a.x.CompareTo(b.x);
            if (result == 0) result = a.y.CompareTo(b.y);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CompareTo(Vector2Int a, Vector2Int b)
        {
            int result = a.x.CompareTo(b.x);
            if (result == 0) result = a.y.CompareTo(b.y);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CompareTo(Vector3 a, Vector3 b)
        {
            int result = a.x.CompareTo(b.x);
            if (result == 0) result = a.y.CompareTo(b.y);
            if (result == 0) result = a.z.CompareTo(b.z);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CompareTo(Vector3Int a, Vector3Int b)
        {
            int result = a.x.CompareTo(b.x);
            if (result == 0) result = a.y.CompareTo(b.y);
            if (result == 0) result = a.z.CompareTo(b.z);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CompareTo(Vector4 a, Vector4 b)
        {
            int result = a.x.CompareTo(b.x);
            if (result == 0) result = a.y.CompareTo(b.y);
            if (result == 0) result = a.z.CompareTo(b.z);
            if (result == 0) result = a.w.CompareTo(b.w);
            return result;
        }
        #endregion

        #region ADD
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(Vector2 a, Vector2 b)
        {
            a.x += b.x;
            a.y += b.y;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(Vector2 v, float f)
        {
            v.x += f;
            v.y += f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(float f, Vector2 v)
        {
            v.x += f;
            v.y += f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(Vector2 v, int i)
        {
            v.x += i;
            v.y += i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(int i, Vector2 v)
        {
            v.x += i;
            v.y += i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Add(Vector2Int a, Vector2Int b)
        {
            a.x += b.x;
            a.y += b.y;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(Vector2Int v, float f)
        {
            Vector2 r;
            r.x = v.x + f;
            r.y = v.y + f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(float f, Vector2Int v)
        {
            Vector2 r;
            r.x = v.x + f;
            r.y = v.y + f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Add(Vector2Int v, int i)
        {
            v.x += i;
            v.y += i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Add(int i, Vector2Int v)
        {
            v.x += i;
            v.y += i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            a.x += b.x;
            a.y += b.y;
            a.z += b.z;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(Vector3 v, float f)
        {
            v.x += f;
            v.y += f;
            v.z += f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(float f, Vector3 v)
        {
            v.x += f;
            v.y += f;
            v.z += f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(Vector3 v, int i)
        {
            v.x += i;
            v.y += i;
            v.z += i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(int i, Vector3 v)
        {
            v.x += i;
            v.y += i;
            v.z += i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Add(Vector3Int a, Vector3Int b)
        {
            a.x += b.x;
            a.y += b.y;
            a.z += b.z;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(Vector3Int v, float f)
        {
            Vector3 r;
            r.x = v.x + f;
            r.y = v.y + f;
            r.z = v.z + f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(float f, Vector3Int v)
        {
            Vector3 r;
            r.x = v.x + f;
            r.y = v.y + f;
            r.z = v.z + f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Add(Vector3Int v, int i)
        {
            v.x += i;
            v.y += i;
            v.z += i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Add(int i, Vector3Int v)
        {
            v.x += i;
            v.y += i;
            v.z += i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Add(Vector4 a, Vector4 b)
        {
            a.x += b.x;
            a.y += b.y;
            a.z += b.z;
            a.w += b.w;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Add(Vector4 v, float f)
        {
            v.x += f;
            v.y += f;
            v.z += f;
            v.w += f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Add(float f, Vector4 v)
        {
            v.x += f;
            v.y += f;
            v.z += f;
            v.w += f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Add(Vector4 v, int i)
        {
            v.x += i;
            v.y += i;
            v.z += i;
            v.w += i;
            return v;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Add(int i, Vector4 v)
        {
            v.x += i;
            v.y += i;
            v.z += i;
            v.w += i;
            return v;
        }

        public static Matrix4x4 Add(Matrix4x4 a, Matrix4x4 b)
        {
            var column0 = a.GetColumn(0) + b.GetColumn(0);
            var column1 = a.GetColumn(1) + b.GetColumn(1);
            var column2 = a.GetColumn(2) + b.GetColumn(2);
            var column3 = a.GetColumn(3) + b.GetColumn(3);

            Matrix4x4 r;
            r.m00 = column0.x;
            r.m01 = column1.x;
            r.m02 = column2.x;
            r.m03 = column3.x;
            r.m10 = column0.y;
            r.m11 = column1.y;
            r.m12 = column2.y;
            r.m13 = column3.y;
            r.m20 = column0.z;
            r.m21 = column1.z;
            r.m22 = column2.z;
            r.m23 = column3.z;
            r.m30 = column0.w;
            r.m31 = column1.w;
            r.m32 = column2.w;
            r.m33 = column3.w;
            return r;
        }

        public static Matrix4x4 Add(Matrix4x4 m, float f)
        {
            var column0 = Add(m.GetColumn(0), f);
            var column1 = Add(m.GetColumn(1), f);
            var column2 = Add(m.GetColumn(2), f);
            var column3 = Add(m.GetColumn(3), f);

            Matrix4x4 r;
            r.m00 = column0.x;
            r.m01 = column1.x;
            r.m02 = column2.x;
            r.m03 = column3.x;
            r.m10 = column0.y;
            r.m11 = column1.y;
            r.m12 = column2.y;
            r.m13 = column3.y;
            r.m20 = column0.z;
            r.m21 = column1.z;
            r.m22 = column2.z;
            r.m23 = column3.z;
            r.m30 = column0.w;
            r.m31 = column1.w;
            r.m32 = column2.w;
            r.m33 = column3.w;
            return r;
        }

        public static Matrix4x4 Add(float f, Matrix4x4 m)
        {
            var column0 = Add(f, m.GetColumn(0));
            var column1 = Add(f, m.GetColumn(1));
            var column2 = Add(f, m.GetColumn(2));
            var column3 = Add(f, m.GetColumn(3));

            Matrix4x4 r;
            r.m00 = column0.x;
            r.m01 = column1.x;
            r.m02 = column2.x;
            r.m03 = column3.x;
            r.m10 = column0.y;
            r.m11 = column1.y;
            r.m12 = column2.y;
            r.m13 = column3.y;
            r.m20 = column0.z;
            r.m21 = column1.z;
            r.m22 = column2.z;
            r.m23 = column3.z;
            r.m30 = column0.w;
            r.m31 = column1.w;
            r.m32 = column2.w;
            r.m33 = column3.w;
            return r;
        }

        public static Matrix4x4 Add(Matrix4x4 m, int i)
        {
            var column0 = Add(m.GetColumn(0), i);
            var column1 = Add(m.GetColumn(1), i);
            var column2 = Add(m.GetColumn(2), i);
            var column3 = Add(m.GetColumn(3), i);

            Matrix4x4 r;
            r.m00 = column0.x;
            r.m01 = column1.x;
            r.m02 = column2.x;
            r.m03 = column3.x;
            r.m10 = column0.y;
            r.m11 = column1.y;
            r.m12 = column2.y;
            r.m13 = column3.y;
            r.m20 = column0.z;
            r.m21 = column1.z;
            r.m22 = column2.z;
            r.m23 = column3.z;
            r.m30 = column0.w;
            r.m31 = column1.w;
            r.m32 = column2.w;
            r.m33 = column3.w;
            return r;
        }

        public static Matrix4x4 Add(int i, Matrix4x4 m)
        {
            var column0 = Add(i, m.GetColumn(0));
            var column1 = Add(i, m.GetColumn(1));
            var column2 = Add(i, m.GetColumn(2));
            var column3 = Add(i, m.GetColumn(3));

            Matrix4x4 r;
            r.m00 = column0.x;
            r.m01 = column1.x;
            r.m02 = column2.x;
            r.m03 = column3.x;
            r.m10 = column0.y;
            r.m11 = column1.y;
            r.m12 = column2.y;
            r.m13 = column3.y;
            r.m20 = column0.z;
            r.m21 = column1.z;
            r.m22 = column2.z;
            r.m23 = column3.z;
            r.m30 = column0.w;
            r.m31 = column1.w;
            r.m32 = column2.w;
            r.m33 = column3.w;
            return r;
        }
        #endregion

        #region SUBTRACT
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(Vector2 a, Vector2 b)
        {
            a.x -= b.x;
            a.y -= b.y;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(Vector2 v, float f)
        {
            v.x -= f;
            v.y -= f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(float f, Vector2 v)
        {
            v.x -= f;
            v.y -= f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(Vector2 v, int i)
        {
            v.x -= i;
            v.y -= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(int i, Vector2 v)
        {
            v.x -= i;
            v.y -= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Sub(Vector2Int a, Vector2Int b)
        {
            a.x -= b.x;
            a.y -= b.y;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(Vector2Int v, float f)
        {
            Vector2 r;
            r.x = v.x - f;
            r.y = v.y - f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(float f, Vector2Int v)
        {
            Vector2 r;
            r.x = v.x - f;
            r.y = v.y - f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Sub(Vector2Int v, int i)
        {
            v.x -= i;
            v.y -= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Sub(int i, Vector2Int v)
        {
            v.x -= i;
            v.y -= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Sub(Vector3 a, Vector3 b)
        {
            a.x -= b.x;
            a.y -= b.y;
            a.z -= b.z;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Sub(Vector3 v, float f)
        {
            v.x -= f;
            v.y -= f;
            v.z -= f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Sub(float f, Vector3 v)
        {
            v.x -= f;
            v.y -= f;
            v.z -= f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Sub(Vector3 v, int i)
        {
            v.x -= i;
            v.y -= i;
            v.z -= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Sub(int i, Vector3 v)
        {
            v.x -= i;
            v.y -= i;
            v.z -= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Sub(Vector3Int a, Vector3Int b)
        {
            a.x -= b.x;
            a.y -= b.y;
            a.z -= b.z;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Sub(Vector3Int v, float f)
        {
            Vector3 r;
            r.x = v.x - f;
            r.y = v.y - f;
            r.z = v.z - f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Sub(float f, Vector3Int v)
        {
            Vector3 r;
            r.x = v.x - f;
            r.y = v.y - f;
            r.z = v.z - f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Sub(Vector3Int v, int i)
        {
            v.x -= i;
            v.y -= i;
            v.z -= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Sub(int i, Vector3Int v)
        {
            v.x -= i;
            v.y -= i;
            v.z -= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Sub(Vector4 a, Vector4 b)
        {
            a.x -= b.x;
            a.y -= b.y;
            a.z -= b.z;
            a.w -= b.w;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Sub(Vector4 v, float f)
        {
            v.x -= f;
            v.y -= f;
            v.z -= f;
            v.w -= f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Sub(float f, Vector4 v)
        {
            v.x -= f;
            v.y -= f;
            v.z -= f;
            v.w -= f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Sub(Vector4 v, int i)
        {
            v.x -= i;
            v.y -= i;
            v.z -= i;
            v.w -= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Sub(int i, Vector4 v)
        {
            v.x -= i;
            v.y -= i;
            v.z -= i;
            v.w -= i;
            return v;
        }

        public static Matrix4x4 Sub(Matrix4x4 a, Matrix4x4 b)
        {
            var column0 = a.GetColumn(0) - b.GetColumn(0);
            var column1 = a.GetColumn(1) - b.GetColumn(1);
            var column2 = a.GetColumn(2) - b.GetColumn(2);
            var column3 = a.GetColumn(3) - b.GetColumn(3);

            Matrix4x4 r;
            r.m00 = column0.x;
            r.m01 = column1.x;
            r.m02 = column2.x;
            r.m03 = column3.x;
            r.m10 = column0.y;
            r.m11 = column1.y;
            r.m12 = column2.y;
            r.m13 = column3.y;
            r.m20 = column0.z;
            r.m21 = column1.z;
            r.m22 = column2.z;
            r.m23 = column3.z;
            r.m30 = column0.w;
            r.m31 = column1.w;
            r.m32 = column2.w;
            r.m33 = column3.w;
            return r;
        }

        public static Matrix4x4 Sub(Matrix4x4 m, float f)
        {
            var column0 = Sub(m.GetColumn(0), f);
            var column1 = Sub(m.GetColumn(1), f);
            var column2 = Sub(m.GetColumn(2), f);
            var column3 = Sub(m.GetColumn(3), f);

            Matrix4x4 r;
            r.m00 = column0.x;
            r.m01 = column1.x;
            r.m02 = column2.x;
            r.m03 = column3.x;
            r.m10 = column0.y;
            r.m11 = column1.y;
            r.m12 = column2.y;
            r.m13 = column3.y;
            r.m20 = column0.z;
            r.m21 = column1.z;
            r.m22 = column2.z;
            r.m23 = column3.z;
            r.m30 = column0.w;
            r.m31 = column1.w;
            r.m32 = column2.w;
            r.m33 = column3.w;
            return r;
        }

        public static Matrix4x4 Sub(float f, Matrix4x4 m)
        {
            var column0 = Sub(f, m.GetColumn(0));
            var column1 = Sub(f, m.GetColumn(1));
            var column2 = Sub(f, m.GetColumn(2));
            var column3 = Sub(f, m.GetColumn(3));

            Matrix4x4 r;
            r.m00 = column0.x;
            r.m01 = column1.x;
            r.m02 = column2.x;
            r.m03 = column3.x;
            r.m10 = column0.y;
            r.m11 = column1.y;
            r.m12 = column2.y;
            r.m13 = column3.y;
            r.m20 = column0.z;
            r.m21 = column1.z;
            r.m22 = column2.z;
            r.m23 = column3.z;
            r.m30 = column0.w;
            r.m31 = column1.w;
            r.m32 = column2.w;
            r.m33 = column3.w;
            return r;
        }

        public static Matrix4x4 Sub(Matrix4x4 m, int i)
        {
            var column0 = Sub(m.GetColumn(0), i);
            var column1 = Sub(m.GetColumn(1), i);
            var column2 = Sub(m.GetColumn(2), i);
            var column3 = Sub(m.GetColumn(3), i);

            Matrix4x4 r;
            r.m00 = column0.x;
            r.m01 = column1.x;
            r.m02 = column2.x;
            r.m03 = column3.x;
            r.m10 = column0.y;
            r.m11 = column1.y;
            r.m12 = column2.y;
            r.m13 = column3.y;
            r.m20 = column0.z;
            r.m21 = column1.z;
            r.m22 = column2.z;
            r.m23 = column3.z;
            r.m30 = column0.w;
            r.m31 = column1.w;
            r.m32 = column2.w;
            r.m33 = column3.w;
            return r;
        }

        public static Matrix4x4 Sub(int i, Matrix4x4 m)
        {
            var column0 = Sub(i, m.GetColumn(0));
            var column1 = Sub(i, m.GetColumn(1));
            var column2 = Sub(i, m.GetColumn(2));
            var column3 = Sub(i, m.GetColumn(3));

            Matrix4x4 r;
            r.m00 = column0.x;
            r.m01 = column1.x;
            r.m02 = column2.x;
            r.m03 = column3.x;
            r.m10 = column0.y;
            r.m11 = column1.y;
            r.m12 = column2.y;
            r.m13 = column3.y;
            r.m20 = column0.z;
            r.m21 = column1.z;
            r.m22 = column2.z;
            r.m23 = column3.z;
            r.m30 = column0.w;
            r.m31 = column1.w;
            r.m32 = column2.w;
            r.m33 = column3.w;
            return r;
        }
        #endregion

        #region MULTIPLY
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mul(Vector2 a, Vector2 b)
        {
            a.x *= b.x;
            a.y *= b.y;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mul(Vector2 v, float f)
        {
            v.x *= f;
            v.y *= f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mul(float f, Vector2 v)
        {
            v.x *= f;
            v.y *= f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mul(Vector2 v, int i)
        {
            v.x *= i;
            v.y *= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mul(int i, Vector2 v)
        {
            v.x *= i;
            v.y *= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Mul(Vector2Int a, Vector2Int b)
        {
            a.x *= b.x;
            a.y *= b.y;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mul(Vector2Int v, float f)
        {
            Vector2 r;
            r.x = v.x * f;
            r.y = v.y * f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mul(float f, Vector2Int v)
        {
            Vector2 r;
            r.x = v.x * f;
            r.y = v.y * f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Mul(Vector2Int v, int i)
        {
            v.x *= i;
            v.y *= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Mul(int i, Vector2Int v)
        {
            v.x *= i;
            v.y *= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mul(Vector3 a, Vector3 b)
        {
            a.x *= b.x;
            a.y *= b.y;
            a.z *= b.z;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mul(Vector3 v, float f)
        {
            v.x *= f;
            v.y *= f;
            v.z *= f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mul(float f, Vector3 v)
        {
            v.x *= f;
            v.y *= f;
            v.z *= f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mul(Vector3 v, int i)
        {
            v.x *= i;
            v.y *= i;
            v.z *= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mul(int i, Vector3 v)
        {
            v.x *= i;
            v.y *= i;
            v.z *= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Mul(Vector3Int a, Vector3Int b)
        {
            a.x *= b.x;
            a.y *= b.y;
            a.z *= b.z;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mul(Vector3Int v, float f)
        {
            Vector3 r;
            r.x = v.x * f;
            r.y = v.y * f;
            r.z = v.z * f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mul(float f, Vector3Int v)
        {
            Vector3 r;
            r.x = v.x * f;
            r.y = v.y * f;
            r.z = v.z * f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Mul(Vector3Int v, int i)
        {
            v.x *= i;
            v.y *= i;
            v.z *= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Mul(int i, Vector3Int v)
        {
            v.x *= i;
            v.y *= i;
            v.z *= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Mul(Vector4 a, Vector4 b)
        {
            a.x *= b.x;
            a.y *= b.y;
            a.z *= b.z;
            a.w *= b.w;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Mul(Vector4 v, float f)
        {
            v.x *= f;
            v.y *= f;
            v.z *= f;
            v.w *= f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Mul(float f, Vector4 v)
        {
            v.x *= f;
            v.y *= f;
            v.z *= f;
            v.w *= f;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Mul(Vector4 v, int i)
        {
            v.x *= i;
            v.y *= i;
            v.z *= i;
            v.w *= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Mul(int i, Vector4 v)
        {
            v.x *= i;
            v.y *= i;
            v.z *= i;
            v.w *= i;
            return v;
        }
        #endregion

        #region DIVIDE
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Div(Vector2 a, Vector2 b)
        {
            a.x /= b.x;
            a.y /= b.y;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Div(Vector2 v, float f)
        {
            var e = 1 / f;
            v.x *= e;
            v.y *= e;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Div(float f, Vector2 v)
        {
            var e = 1 / f;
            v.x *= e;
            v.y *= e;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Div(Vector2 v, int i)
        {
            var e = 1.0f / i;
            v.x *= e;
            v.y *= e;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Div(int i, Vector2 v)
        {
            var e = 1.0f / i;
            v.x *= e;
            v.y *= e;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Div(Vector2Int a, Vector2Int b)
        {
            a.x /= b.x;
            a.y /= b.y;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Div(Vector2Int v, float f)
        {
            var e = 1 / f;
            Vector2 r;
            r.x = v.x * e;
            r.y = v.y * e;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Div(float f, Vector2Int v)
        {
            var e = 1 / f;
            Vector2 r;
            r.x = v.x * e;
            r.y = v.y * e;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Div(Vector2Int v, int i)
        {
            v.x /= i;
            v.y /= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Div(int i, Vector2Int v)
        {
            v.x /= i;
            v.y /= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Div(Vector3 a, Vector3 b)
        {
            a.x /= b.x;
            a.y /= b.y;
            a.z /= b.z;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Div(Vector3 v, float f)
        {
            var e = 1 / f;
            v.x *= e;
            v.y *= e;
            v.z *= e;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Div(float f, Vector3 v)
        {
            var e = 1 / f;
            v.x *= e;
            v.y *= e;
            v.z *= e;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Div(Vector3 v, int i)
        {
            var e = 1.0f / i;
            v.x *= e;
            v.y *= e;
            v.z *= e;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Div(int i, Vector3 v)
        {
            var e = 1.0f / i;
            v.x *= e;
            v.y *= e;
            v.z *= e;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Div(Vector3Int a, Vector3Int b)
        {
            a.x /= b.x;
            a.y /= b.y;
            a.z /= b.z;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Div(Vector3Int v, float f)
        {
            var e = 1 / f;
            Vector3 r;
            r.x = v.x * e;
            r.y = v.y * e;
            r.z = v.z * e;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Div(float f, Vector3Int v)
        {
            var e = 1 / f;
            Vector3 r;
            r.x = v.x * e;
            r.y = v.y * e;
            r.z = v.z * e;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Div(Vector3Int v, int i)
        {
            v.x /= i;
            v.y /= i;
            v.z /= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Div(int i, Vector3Int v)
        {
            v.x /= i;
            v.y /= i;
            v.z /= i;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Div(Vector4 a, Vector4 b)
        {
            a.x /= b.x;
            a.y /= b.y;
            a.z /= b.z;
            a.w /= b.w;
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Div(Vector4 v, float f)
        {
            var e = 1 / f;
            v.x *= e;
            v.y *= e;
            v.z *= e;
            v.w *= e;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Div(float f, Vector4 v)
        {
            var e = 1 / f;
            v.x *= e;
            v.y *= e;
            v.z *= e;
            v.w *= e;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Div(Vector4 v, int i)
        {
            var e = 1.0f / i;
            v.x *= e;
            v.y *= e;
            v.z *= e;
            v.w *= e;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Div(int i, Vector4 v)
        {
            var e = 1.0f / i;
            v.x *= e;
            v.y *= e;
            v.z *= e;
            v.w *= e;
            return v;
        }
        #endregion

        #region ARE_EQUAL
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(Vector2 a, Vector2 b, float e = kEpsilon)
        {
            return new Bool2(
                IsZero(a.x - b.x, e),
                IsZero(a.y - b.y, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(Vector2 v, float f, float e = kEpsilon)
        {
            return new Bool2(
                IsZero(v.x - f, e),
                IsZero(v.y - f, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(float f, Vector2 v, float e = kEpsilon)
        {
            return new Bool2(
                IsZero(f - v.x, e),
                IsZero(f - v.y, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(Vector2 v, int i, float e = kEpsilon)
        {
            return new Bool2(
                IsZero(v.x - i, e),
                IsZero(v.y - i, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(int i, Vector2 v, float e = kEpsilon)
        {
            return new Bool2(
                IsZero(i - v.x, e),
                IsZero(i - v.y, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(Vector2Int a, Vector2Int b)
        {
            return new Bool2(
                a.x == b.x,
                a.y == b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(Vector2Int v, float f, float e = kEpsilon)
        {
            return new Bool2(
                IsZero(v.x - f, e),
                IsZero(v.y - f, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(float f, Vector2Int v, float e = kEpsilon)
        {
            return new Bool2(
                IsZero(f - v.x, e),
                IsZero(f - v.y, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(Vector2Int v, int i)
        {
            return new Bool2(
                v.x == i,
                v.y == i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(int i, Vector2Int v)
        {
            return new Bool2(
                i == v.x,
                i == v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreEqual(Vector3 a, Vector3 b, float e = kEpsilon)
        {
            return new Bool3(
                IsZero(a.x - b.x, e),
                IsZero(a.y - b.y, e),
                IsZero(a.z - b.z, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreEqual(Vector3 v, float f, float e = kEpsilon)
        {
            return new Bool3(
                IsZero(v.x - f, e),
                IsZero(v.y - f, e),
                IsZero(v.z - f, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreEqual(float f, Vector3 v, float e = kEpsilon)
        {
            return new Bool3(
                IsZero(f - v.x, e),
                IsZero(f - v.y, e),
                IsZero(f - v.z, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreEqual(Vector3 v, int i, float e = kEpsilon)
        {
            return new Bool3(
                IsZero(v.x - i, e),
                IsZero(v.y - i, e),
                IsZero(v.z - i, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreEqual(int i, Vector3 v, float e = kEpsilon)
        {
            return new Bool3(
                IsZero(i - v.x, e),
                IsZero(i - v.y, e),
                IsZero(i - v.z, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreEqual(Vector3Int a, Vector3Int b)
        {
            return new Bool3(
                a.x == b.x,
                a.y == b.y,
                a.z == b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreEqual(Vector3Int v, float f, float e = kEpsilon)
        {
            return new Bool3(
                IsZero(v.x - f, e),
                IsZero(v.y - f, e),
                IsZero(v.z - f, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreEqual(float f, Vector3Int v, float e = kEpsilon)
        {
            return new Bool3(
                IsZero(f - v.x, e),
                IsZero(f - v.y, e),
                IsZero(f - v.z, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreEqual(Vector3Int v, int i)
        {
            return new Bool3(
                v.x == i,
                v.y == i,
                v.z == i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreEqual(int i, Vector3Int v)
        {
            return new Bool3(
                i == v.x,
                i == v.y,
                i == v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreEqual(Vector4 a, Vector4 b, float e = kEpsilon)
        {
            return new Bool4(
                IsZero(a.x - b.x, e),
                IsZero(a.y - b.y, e),
                IsZero(a.z - b.z, e),
                IsZero(a.w - b.w, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreEqual(Vector4 v, float f, float e = kEpsilon)
        {
            return new Bool4(
                IsZero(v.x - f, e),
                IsZero(v.y - f, e),
                IsZero(v.z - f, e),
                IsZero(v.w - f, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreEqual(float f, Vector4 v, float e = kEpsilon)
        {
            return new Bool4(
                IsZero(f - v.x, e),
                IsZero(f - v.y, e),
                IsZero(f - v.z, e),
                IsZero(f - v.w, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreEqual(Vector4 v, int i, float e = kEpsilon)
        {
            return new Bool4(
                IsZero(v.x - i, e),
                IsZero(v.y - i, e),
                IsZero(v.z - i, e),
                IsZero(v.w - i, e)
            );
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreEqual(int i, Vector4 v, float e = kEpsilon)
        {
            return new Bool4(
                IsZero(i - v.x, e),
                IsZero(i - v.y, e),
                IsZero(i - v.z, e),
                IsZero(i - v.w, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreEqual(Quaternion a, Quaternion b, float e = kEpsilon)
        {
            return new Bool4(
                IsEqual(a.x, b.x, e),
                IsEqual(a.y, b.y, e),
                IsEqual(a.z, b.z, e),
                IsEqual(a.w, b.w, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreEqual(Matrix4x4 a, Matrix4x4 b, float e = kEpsilon)
        {
            return new Bool4(
                IsEqual(a.GetColumn(0), b.GetColumn(0), e),
                IsEqual(a.GetColumn(1), b.GetColumn(1), e),
                IsEqual(a.GetColumn(2), b.GetColumn(2), e),
                IsEqual(a.GetColumn(3), b.GetColumn(3), e)
            );
        }
        #endregion

        #region ARE_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreater(Vector2 a, Vector2 b)
        {
            return new Bool2(
                a.x > b.x,
                a.y > b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreater(Vector2 v, float f)
        {
            return new Bool2(
                v.x > f,
                v.y > f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreater(float f, Vector2 v)
        {
            return new Bool2(
                f > v.x,
                f > v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreater(Vector2 v, int i)
        {
            return new Bool2(
                v.x > i,
                v.y > i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreater(int i, Vector2 v)
        {
            return new Bool2(
                i > v.x,
                i > v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreater(Vector2Int a, Vector2Int b)
        {
            return new Bool2(
                a.x > b.x,
                a.y > b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreater(Vector2Int v, float f)
        {
            return new Bool2(
                v.x > f,
                v.y > f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreater(float f, Vector2Int v)
        {
            return new Bool2(
                f > v.x,
                f > v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreater(Vector2Int v, int i)
        {
            return new Bool2(
                v.x > i,
                v.y > i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreater(int i, Vector2Int v)
        {
            return new Bool2(
                i > v.x,
                i > v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreater(Vector3 a, Vector3 b)
        {
            return new Bool3(
                a.x > b.x,
                a.y > b.y,
                a.z > b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreater(Vector3 v, float f)
        {
            return new Bool3(
                v.x > f,
                v.y > f,
                v.z > f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreater(float f, Vector3 v)
        {
            return new Bool3(
                f > v.x,
                f > v.y,
                f > v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreater(Vector3 v, int i)
        {
            return new Bool3(
                v.x > i,
                v.y > i,
                v.z > i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreater(int i, Vector3 v)
        {
            return new Bool3(
                i > v.x,
                i > v.y,
                i > v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreater(Vector3Int a, Vector3Int b)
        {
            return new Bool3(
                a.x > b.x,
                a.y > b.y,
                a.z > b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreater(Vector3Int v, float f)
        {
            return new Bool3(
                v.x > f,
                v.y > f,
                v.z > f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreater(float f, Vector3Int v)
        {
            return new Bool3(
                f > v.x,
                f > v.y,
                f > v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreater(Vector3Int v, int i)
        {
            return new Bool3(
                v.x > i,
                v.y > i,
                v.z > i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreater(int i, Vector3Int v)
        {
            return new Bool3(
                i > v.x,
                i > v.y,
                i > v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreGreater(Vector4 a, Vector4 b)
        {
            return new Bool4(
                a.x > b.x,
                a.y > b.y,
                a.z > b.z,
                a.w > b.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreGreater(Vector4 v, float f)
        {
            return new Bool4(
                v.x > f,
                v.y > f,
                v.z > f,
                v.w > f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreGreater(float f, Vector4 v)
        {
            return new Bool4(
                f > v.x,
                f > v.y,
                f > v.z,
                f > v.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreGreater(Vector4 v, int i)
        {
            return new Bool4(
                v.x > i,
                v.y > i,
                v.z > i,
                v.w > i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreGreater(int i, Vector4 v)
        {
            return new Bool4(
                i > v.x,
                i > v.y,
                i > v.z,
                i > v.w
            );
        }
        #endregion

        #region ARE_GREATER_OR_EQUAL
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreaterOrEqual(Vector2 a, Vector2 b)
        {
            return new Bool2(
                a.x >= b.x,
                a.y >= b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreaterOrEqual(Vector2 v, float f)
        {
            return new Bool2(
                v.x >= f,
                v.y >= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreaterOrEqual(float f, Vector2 v)
        {
            return new Bool2(
                f >= v.x,
                f >= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreaterOrEqual(Vector2 v, int i)
        {
            return new Bool2(
                v.x >= i,
                v.y >= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreaterOrEqual(int i, Vector2 v)
        {
            return new Bool2(
                i >= v.x,
                i >= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreaterOrEqual(Vector2Int a, Vector2Int b)
        {
            return new Bool2(
                a.x >= b.x,
                a.y >= b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreaterOrEqual(Vector2Int v, float f)
        {
            return new Bool2(
                v.x >= f,
                v.y >= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreaterOrEqual(float f, Vector2Int v)
        {
            return new Bool2(
                f >= v.x,
                f >= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreaterOrEqual(Vector2Int v, int i)
        {
            return new Bool2(
                v.x >= i,
                v.y >= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreGreaterOrEqual(int i, Vector2Int v)
        {
            return new Bool2(
                i >= v.x,
                i >= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreaterOrEqual(Vector3 a, Vector3 b)
        {
            return new Bool3(
                a.x >= b.x,
                a.y >= b.y,
                a.z >= b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreaterOrEqual(Vector3 v, float f)
        {
            return new Bool3(
                v.x >= f,
                v.y >= f,
                v.z >= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreaterOrEqual(float f, Vector3 v)
        {
            return new Bool3(
                f >= v.x,
                f >= v.y,
                f >= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreaterOrEqual(Vector3 v, int i)
        {
            return new Bool3(
                v.x >= i,
                v.y >= i,
                v.z >= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreaterOrEqual(int i, Vector3 v)
        {
            return new Bool3(
                i >= v.x,
                i >= v.y,
                i >= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreaterOrEqual(Vector3Int a, Vector3Int b)
        {
            return new Bool3(
                a.x >= b.x,
                a.y >= b.y,
                a.z >= b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreaterOrEqual(Vector3Int v, float f)
        {
            return new Bool3(
                v.x >= f,
                v.y >= f,
                v.z >= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreaterOrEqual(float f, Vector3Int v)
        {
            return new Bool3(
                f >= v.x,
                f >= v.y,
                f >= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreaterOrEqual(Vector3Int v, int i)
        {
            return new Bool3(
                v.x >= i,
                v.y >= i,
                v.z >= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreGreaterOrEqual(int i, Vector3Int v)
        {
            return new Bool3(
                i >= v.x,
                i >= v.y,
                i >= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreGreaterOrEqual(Vector4 a, Vector4 b)
        {
            return new Bool4(
                a.x >= b.x,
                a.y >= b.y,
                a.z >= b.z,
                a.w >= b.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreGreaterOrEqual(Vector4 v, float f)
        {
            return new Bool4(
                v.x >= f,
                v.y >= f,
                v.z >= f,
                v.w >= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreGreaterOrEqual(float f, Vector4 v)
        {
            return new Bool4(
                f >= v.x,
                f >= v.y,
                f >= v.z,
                f >= v.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreGreaterOrEqual(Vector4 v, int i)
        {
            return new Bool4(
                v.x >= i,
                v.y >= i,
                v.z >= i,
                v.w >= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreGreaterOrEqual(int i, Vector4 v)
        {
            return new Bool4(
                i >= v.x,
                i >= v.y,
                i >= v.z,
                i >= v.w
            );
        }
        #endregion

        #region ARE_LESSER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesser(Vector2 a, Vector2 b)
        {
            return new Bool2(
                a.x < b.x,
                a.y < b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesser(Vector2 v, float f)
        {
            return new Bool2(
                v.x < f,
                v.y < f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesser(float f, Vector2 v)
        {
            return new Bool2(
                f < v.x,
                f < v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesser(Vector2 v, int i)
        {
            return new Bool2(
                v.x < i,
                v.y < i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesser(int i, Vector2 v)
        {
            return new Bool2(
                i < v.x,
                i < v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesser(Vector2Int a, Vector2Int b)
        {
            return new Bool2(
                a.x < b.x,
                a.y < b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesser(Vector2Int v, float f)
        {
            return new Bool2(
                v.x < f,
                v.y < f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesser(float f, Vector2Int v)
        {
            return new Bool2(
                f < v.x,
                f < v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesser(Vector2Int v, int i)
        {
            return new Bool2(
                v.x < i,
                v.y < i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesser(int i, Vector2Int v)
        {
            return new Bool2(
                i < v.x,
                i < v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesser(Vector3 a, Vector3 b)
        {
            return new Bool3(
                a.x < b.x,
                a.y < b.y,
                a.z < b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesser(Vector3 v, float f)
        {
            return new Bool3(
                v.x < f,
                v.y < f,
                v.z < f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesser(float f, Vector3 v)
        {
            return new Bool3(
                f < v.x,
                f < v.y,
                f < v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesser(Vector3 v, int i)
        {
            return new Bool3(
                v.x < i,
                v.y < i,
                v.z < i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesser(int i, Vector3 v)
        {
            return new Bool3(
                i < v.x,
                i < v.y,
                i < v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesser(Vector3Int a, Vector3Int b)
        {
            return new Bool3(
                a.x < b.x,
                a.y < b.y,
                a.z < b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesser(Vector3Int v, float f)
        {
            return new Bool3(
                v.x < f,
                v.y < f,
                v.z < f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesser(float f, Vector3Int v)
        {
            return new Bool3(
                f < v.x,
                f < v.y,
                f < v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesser(Vector3Int v, int i)
        {
            return new Bool3(
                v.x < i,
                v.y < i,
                v.z < i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesser(int i, Vector3Int v)
        {
            return new Bool3(
                i < v.x,
                i < v.y,
                i < v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreLesser(Vector4 a, Vector4 b)
        {
            return new Bool4(
                a.x < b.x,
                a.y < b.y,
                a.z < b.z,
                a.w < b.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreLesser(Vector4 v, float f)
        {
            return new Bool4(
                v.x < f,
                v.y < f,
                v.z < f,
                v.w < f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreLesser(float f, Vector4 v)
        {
            return new Bool4(
                f < v.x,
                f < v.y,
                f < v.z,
                f < v.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreLesser(Vector4 v, int i)
        {
            return new Bool4(
                v.x < i,
                v.y < i,
                v.z < i,
                v.w < i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreLesser(int i, Vector4 v)
        {
            return new Bool4(
                i < v.x,
                i < v.y,
                i < v.z,
                i < v.w
            );
        }
        #endregion

        #region ARE_LESSER_OR_EQUAL
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesserOrEqual(Vector2 a, Vector2 b)
        {
            return new Bool2(
                a.x <= b.x,
                a.y <= b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesserOrEqual(Vector2 v, float f)
        {
            return new Bool2(
                v.x <= f,
                v.y <= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesserOrEqual(float f, Vector2 v)
        {
            return new Bool2(
                f <= v.x,
                f <= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesserOrEqual(Vector2 v, int i)
        {
            return new Bool2(
                v.x <= i,
                v.y <= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesserOrEqual(int i, Vector2 v)
        {
            return new Bool2(
                i <= v.x,
                i <= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesserOrEqual(Vector2Int a, Vector2Int b)
        {
            return new Bool2(
                a.x <= b.x,
                a.y <= b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesserOrEqual(Vector2Int v, float f)
        {
            return new Bool2(
                v.x <= f,
                v.y <= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesserOrEqual(float f, Vector2Int v)
        {
            return new Bool2(
                f <= v.x,
                f <= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesserOrEqual(Vector2Int v, int i)
        {
            return new Bool2(
                v.x <= i,
                v.y <= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreLesserOrEqual(int i, Vector2Int v)
        {
            return new Bool2(
                i <= v.x,
                i <= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesserOrEqual(Vector3 a, Vector3 b)
        {
            return new Bool3(
                a.x <= b.x,
                a.y <= b.y,
                a.z <= b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesserOrEqual(Vector3 v, float f)
        {
            return new Bool3(
                v.x <= f,
                v.y <= f,
                v.z <= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesserOrEqual(float f, Vector3 v)
        {
            return new Bool3(
                f <= v.x,
                f <= v.y,
                f <= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesserOrEqual(Vector3 v, int i)
        {
            return new Bool3(
                v.x <= i,
                v.y <= i,
                v.z <= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesserOrEqual(int i, Vector3 v)
        {
            return new Bool3(
                i <= v.x,
                i <= v.y,
                i <= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesserOrEqual(Vector3Int a, Vector3Int b)
        {
            return new Bool3(
                a.x <= b.x,
                a.y <= b.y,
                a.z <= b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesserOrEqual(Vector3Int v, float f)
        {
            return new Bool3(
                v.x <= f,
                v.y <= f,
                v.z <= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesserOrEqual(float f, Vector3Int v)
        {
            return new Bool3(
                f <= v.x,
                f <= v.y,
                f <= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesserOrEqual(Vector3Int v, int i)
        {
            return new Bool3(
                v.x <= i,
                v.y <= i,
                v.z <= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreLesserOrEqual(int i, Vector3Int v)
        {
            return new Bool3(
                i <= v.x,
                i <= v.y,
                i <= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreLesserOrEqual(Vector4 a, Vector4 b)
        {
            return new Bool4(
                a.x <= b.x,
                a.y <= b.y,
                a.z <= b.z,
                a.w <= b.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreLesserOrEqual(Vector4 v, float f)
        {
            return new Bool4(
                v.x <= f,
                v.y <= f,
                v.z <= f,
                v.w <= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreLesserOrEqual(float f, Vector4 v)
        {
            return new Bool4(
                f <= v.x,
                f <= v.y,
                f <= v.z,
                f <= v.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreLesserOrEqual(Vector4 v, int i)
        {
            return new Bool4(
                v.x <= i,
                v.y <= i,
                v.z <= i,
                v.w <= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreLesserOrEqual(int i, Vector4 v)
        {
            return new Bool4(
                i <= v.x,
                i <= v.y,
                i <= v.z,
                i <= v.w
            );
        }
        #endregion

        #region IS_EQUAL
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(float a, float b, float e = kEpsilon)
        {
            return IsZero(a - b, e);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector2 a, Vector2 b, float e = kEpsilon)
        {
            return (
                IsZero(a.x - b.x, e) &&
                IsZero(a.y - b.y, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector2 v, float f, float e = kEpsilon)
        {
            return (
                IsZero(v.x - f, e) &&
                IsZero(v.y - f, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(float f, Vector2 v, float e = kEpsilon)
        {
            return (
                IsZero(f - v.x, e) &&
                IsZero(f - v.y, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector2 v, int i, float e = kEpsilon)
        {
            return (
                IsZero(v.x - i, e) &&
                IsZero(v.y - i, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(int i, Vector2 v, float e = kEpsilon)
        {
            return (
                IsZero(i - v.x, e) &&
                IsZero(i - v.y, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector2Int a, Vector2Int b)
        {
            return (
                a.x == b.x &&
                a.y == b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector2Int v, float f, float e = kEpsilon)
        {
            return (
                IsZero(v.x - f, e) &&
                IsZero(v.y - f, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(float f, Vector2Int v, float e = kEpsilon)
        {
            return (
                IsZero(f - v.x, e) &&
                IsZero(f - v.y, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector2Int v, int i)
        {
            return (
                v.x == i &&
                v.y == i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(int i, Vector2Int v)
        {
            return (
                i == v.x &&
                i == v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector3 a, Vector3 b, float e = kEpsilon)
        {
            return (
                IsZero(a.x - b.x, e) &&
                IsZero(a.y - b.y, e) &&
                IsZero(a.z - b.z, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector3 v, float f, float e = kEpsilon)
        {
            return (
                IsZero(v.x - f, e) &&
                IsZero(v.y - f, e) &&
                IsZero(v.z - f, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(float f, Vector3 v, float e = kEpsilon)
        {
            return (
                IsZero(f - v.x, e) &&
                IsZero(f - v.y, e) &&
                IsZero(f - v.z, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector3 v, int i, float e = kEpsilon)
        {
            return (
                IsZero(v.x - i, e) &&
                IsZero(v.y - i, e) &&
                IsZero(v.z - i, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(int i, Vector3 v, float e = kEpsilon)
        {
            return (
                IsZero(i - v.x, e) &&
                IsZero(i - v.y, e) &&
                IsZero(i - v.z, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector3Int a, Vector3Int b)
        {
            return (
                a.x == b.x &&
                a.y == b.y &&
                a.z == b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector3Int v, float f, float e = kEpsilon)
        {
            return (
                IsZero(v.x - f, e) &&
                IsZero(v.y - f, e) &&
                IsZero(v.z - f, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(float f, Vector3Int v, float e = kEpsilon)
        {
            return (
                IsZero(f - v.x, e) &&
                IsZero(f - v.y, e) &&
                IsZero(f - v.z, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector3Int v, int i)
        {
            return (
                v.x == i &&
                v.y == i &&
                v.z == i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(int i, Vector3Int v)
        {
            return (
                i == v.x &&
                i == v.y &&
                i == v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector4 a, Vector4 b, float e = kEpsilon)
        {
            return (
                IsZero(a.x - b.x, e) &&
                IsZero(a.y - b.y, e) &&
                IsZero(a.z - b.z, e) &&
                IsZero(a.w - b.w, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector4 v, float f, float e = kEpsilon)
        {
            return (
                IsZero(v.x - f, e) &&
                IsZero(v.y - f, e) &&
                IsZero(v.z - f, e) &&
                IsZero(v.w - f, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(float f, Vector4 v, float e = kEpsilon)
        {
            return (
                IsZero(f - v.x, e) &&
                IsZero(f - v.y, e) &&
                IsZero(f - v.z, e) &&
                IsZero(f - v.w, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector4 v, int i, float e = kEpsilon)
        {
            return (
                IsZero(v.x - i, e) &&
                IsZero(v.y - i, e) &&
                IsZero(v.z - i, e) &&
                IsZero(v.w - i, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(int i, Vector4 v, float e = kEpsilon)
        {
            return (
                IsZero(i - v.x, e) &&
                IsZero(i - v.y, e) &&
                IsZero(i - v.z, e) &&
                IsZero(i - v.w, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Color a, Color b, float e = kEpsilon)
        {
            return (
                IsZero(a.r - b.r, e) &&
                IsZero(a.g - b.g, e) &&
                IsZero(a.b - b.b, e) &&
                IsZero(a.a - b.a, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Color c, float f, float e = kEpsilon)
        {
            return (
                IsZero(c.r - f, e) &&
                IsZero(c.g - f, e) &&
                IsZero(c.b - f, e) &&
                IsZero(c.a - f, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(float f, Color c, float e = kEpsilon)
        {
            return (
                IsZero(f - c.r, e) &&
                IsZero(f - c.g, e) &&
                IsZero(f - c.b, e) &&
                IsZero(f - c.a, e)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Color32 a, Color32 b)
        {
            return (
                a.r == b.r &&
                a.g == b.g &&
                a.b == b.b &&
                a.a == b.a
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Color32 c, byte b)
        {
            return (
                c.r == b &&
                c.g == b &&
                c.b == b &&
                c.a == b
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(byte b, Color32 c)
        {
            return (
                b == c.r &&
                b == c.g &&
                b == c.b &&
                b == c.a
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Quaternion a, Quaternion b, float e = kEpsilon)
        {
            return IsZero(Quaternion.Dot(a, b), e);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Matrix4x4 a, Matrix4x4 b, float e = kEpsilon)
        {
            return (
                IsEqual(a.GetColumn(0), b.GetColumn(0), e) &&
                IsEqual(a.GetColumn(1), b.GetColumn(1), e) &&
                IsEqual(a.GetColumn(2), b.GetColumn(2), e) &&
                IsEqual(a.GetColumn(3), b.GetColumn(3), e)
            );
        }
        #endregion

        #region IS_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(Vector2 a, Vector2 b)
        {
            return (
                a.x > b.x &&
                a.y > b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(Vector2 v, float f)
        {
            return (
                v.x > f &&
                v.y > f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(float f, Vector2 v)
        {
            return (
                f > v.x &&
                f > v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(Vector2 v, int i)
        {
            return (
                v.x > i &&
                v.y > i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(int i, Vector2 v)
        {
            return (
                i > v.x &&
                i > v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(Vector2Int a, Vector2Int b)
        {
            return (
                a.x > b.x &&
                a.y > b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(Vector2Int v, float f)
        {
            return (
                v.x > f &&
                v.y > f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(float f, Vector2Int v)
        {
            return (
                f > v.x &&
                f > v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(Vector2Int v, int i)
        {
            return (
                v.x > i &&
                v.y > i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(int i, Vector2Int v)
        {
            return (
                i > v.x &&
                i > v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(Vector3 a, Vector3 b)
        {
            return (
                a.x > b.x &&
                a.y > b.y &&
                a.z > b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(Vector3 v, float f)
        {
            return (
                v.x > f &&
                v.y > f &&
                v.z > f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(float f, Vector3 v)
        {
            return (
                f > v.x &&
                f > v.y &&
                f > v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(Vector3 v, int i)
        {
            return (
                v.x > i &&
                v.y > i &&
                v.z > i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(int i, Vector3 v)
        {
            return (
                i > v.x &&
                i > v.y &&
                i > v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(Vector3Int a, Vector3Int b)
        {
            return (
                a.x > b.x &&
                a.y > b.y &&
                a.z > b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(Vector3Int v, float f)
        {
            return (
                v.x > f &&
                v.y > f &&
                v.z > f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(float f, Vector3Int v)
        {
            return (
                f > v.x &&
                f > v.y &&
                f > v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(Vector3Int v, int i)
        {
            return (
                v.x > i &&
                v.y > i &&
                v.z > i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(int i, Vector3Int v)
        {
            return (
                i > v.x &&
                i > v.y &&
                i > v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(Vector4 a, Vector4 b)
        {
            return (
                a.x > b.x &&
                a.y > b.y &&
                a.z > b.z &&
                a.w > b.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(Vector4 v, float f)
        {
            return (
                v.x > f &&
                v.y > f &&
                v.z > f &&
                v.w > f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(float f, Vector4 v)
        {
            return (
                f > v.x &&
                f > v.y &&
                f > v.z &&
                f > v.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(Vector4 v, int i)
        {
            return (
                v.x > i &&
                v.y > i &&
                v.z > i &&
                v.w > i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreater(int i, Vector4 v)
        {
            return (
                i > v.x &&
                i > v.y &&
                i > v.z &&
                i > v.w
            );
        }
        #endregion

        #region IS_GREATER_OR_EQUAL
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(Vector2 a, Vector2 b)
        {
            return (
                a.x >= b.x &&
                a.y >= b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(Vector2 v, float f)
        {
            return (
                v.x >= f &&
                v.y >= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(float f, Vector2 v)
        {
            return (
                f >= v.x &&
                f >= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(Vector2 v, int i)
        {
            return (
                v.x >= i &&
                v.y >= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(int i, Vector2 v)
        {
            return (
                i >= v.x &&
                i >= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(Vector2Int a, Vector2Int b)
        {
            return (
                a.x >= b.x &&
                a.y >= b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(Vector2Int v, float f)
        {
            return (
                v.x >= f &&
                v.y >= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(float f, Vector2Int v)
        {
            return (
                f >= v.x &&
                f >= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(Vector2Int v, int i)
        {
            return (
                v.x >= i &&
                v.y >= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(int i, Vector2Int v)
        {
            return (
                i >= v.x &&
                i >= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(Vector3 a, Vector3 b)
        {
            return (
                a.x >= b.x &&
                a.y >= b.y &&
                a.z >= b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(Vector3 v, float f)
        {
            return (
                v.x >= f &&
                v.y >= f &&
                v.z >= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(float f, Vector3 v)
        {
            return (
                f >= v.x &&
                f >= v.y &&
                f >= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(Vector3 v, int i)
        {
            return (
                v.x >= i &&
                v.y >= i &&
                v.z >= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(int i, Vector3 v)
        {
            return (
                i >= v.x &&
                i >= v.y &&
                i >= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(Vector3Int a, Vector3Int b)
        {
            return (
                a.x >= b.x &&
                a.y >= b.y &&
                a.z >= b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(Vector3Int v, float f)
        {
            return (
                v.x >= f &&
                v.y >= f &&
                v.z >= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(float f, Vector3Int v)
        {
            return (
                f >= v.x &&
                f >= v.y &&
                f >= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(Vector3Int v, int i)
        {
            return (
                v.x >= i &&
                v.y >= i &&
                v.z >= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(int i, Vector3Int v)
        {
            return (
                i >= v.x &&
                i >= v.y &&
                i >= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(Vector4 a, Vector4 b)
        {
            return (
                a.x >= b.x &&
                a.y >= b.y &&
                a.z >= b.z &&
                a.w >= b.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(Vector4 v, float f)
        {
            return (
                v.x >= f &&
                v.y >= f &&
                v.z >= f &&
                v.w >= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(float f, Vector4 v)
        {
            return (
                f >= v.x &&
                f >= v.y &&
                f >= v.z &&
                f >= v.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(Vector4 v, int i)
        {
            return (
                v.x >= i &&
                v.y >= i &&
                v.z >= i &&
                v.w >= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterOrEqual(int i, Vector4 v)
        {
            return (
                i >= v.x &&
                i >= v.y &&
                i >= v.z &&
                i >= v.w
            );
        }
        #endregion

        #region IS_LESSER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(Vector2 a, Vector2 b)
        {
            return (
                a.x < b.x &&
                a.y < b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(Vector2 v, float f)
        {
            return (
                v.x < f &&
                v.y < f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(float f, Vector2 v)
        {
            return (
                f < v.x &&
                f < v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(Vector2 v, int i)
        {
            return (
                v.x < i &&
                v.y < i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(int i, Vector2 v)
        {
            return (
                i < v.x &&
                i < v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(Vector2Int a, Vector2Int b)
        {
            return (
                a.x < b.x &&
                a.y < b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(Vector2Int v, float f)
        {
            return (
                v.x < f &&
                v.y < f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(float f, Vector2Int v)
        {
            return (
                f < v.x &&
                f < v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(Vector2Int v, int i)
        {
            return (
                v.x < i &&
                v.y < i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(int i, Vector2Int v)
        {
            return (
                i < v.x &&
                i < v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(Vector3 a, Vector3 b)
        {
            return (
                a.x < b.x &&
                a.y < b.y &&
                a.z < b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(Vector3 v, float f)
        {
            return (
                v.x < f &&
                v.y < f &&
                v.z < f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(float f, Vector3 v)
        {
            return (
                f < v.x &&
                f < v.y &&
                f < v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(Vector3 v, int i)
        {
            return (
                v.x < i &&
                v.y < i &&
                v.z < i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(int i, Vector3 v)
        {
            return (
                i < v.x &&
                i < v.y &&
                i < v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(Vector3Int a, Vector3Int b)
        {
            return (
                a.x < b.x &&
                a.y < b.y &&
                a.z < b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(Vector3Int v, float f)
        {
            return (
                v.x < f &&
                v.y < f &&
                v.z < f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(float f, Vector3Int v)
        {
            return (
                f < v.x &&
                f < v.y &&
                f < v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(Vector3Int v, int i)
        {
            return (
                v.x < i &&
                v.y < i &&
                v.z < i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(int i, Vector3Int v)
        {
            return (
                i < v.x &&
                i < v.y &&
                i < v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(Vector4 a, Vector4 b)
        {
            return (
                a.x < b.x &&
                a.y < b.y &&
                a.z < b.z &&
                a.w < b.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(Vector4 v, float f)
        {
            return (
                v.x < f &&
                v.y < f &&
                v.z < f &&
                v.w < f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(float f, Vector4 v)
        {
            return (
                f < v.x &&
                f < v.y &&
                f < v.z &&
                f < v.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(Vector4 v, int i)
        {
            return (
                v.x < i &&
                v.y < i &&
                v.z < i &&
                v.w < i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesser(int i, Vector4 v)
        {
            return (
                i < v.x &&
                i < v.y &&
                i < v.z &&
                i < v.w
            );
        }
        #endregion

        #region IS_LESSER_OR_EQUAL
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(Vector2 a, Vector2 b)
        {
            return (
                a.x <= b.x &&
                a.y <= b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(Vector2 v, float f)
        {
            return (
                v.x <= f &&
                v.y <= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(float f, Vector2 v)
        {
            return (
                f <= v.x &&
                f <= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(Vector2 v, int i)
        {
            return (
                v.x <= i &&
                v.y <= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(int i, Vector2 v)
        {
            return (
                i <= v.x &&
                i <= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(Vector2Int a, Vector2Int b)
        {
            return (
                a.x <= b.x &&
                a.y <= b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(Vector2Int v, float f)
        {
            return (
                v.x <= f &&
                v.y <= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(float f, Vector2Int v)
        {
            return (
                f <= v.x &&
                f <= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(Vector2Int v, int i)
        {
            return (
                v.x <= i &&
                v.y <= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(int i, Vector2Int v)
        {
            return (
                i <= v.x &&
                i <= v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(Vector3 a, Vector3 b)
        {
            return (
                a.x <= b.x &&
                a.y <= b.y &&
                a.z <= b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(Vector3 v, float f)
        {
            return (
                v.x <= f &&
                v.y <= f &&
                v.z <= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(float f, Vector3 v)
        {
            return (
                f <= v.x &&
                f <= v.y &&
                f <= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(Vector3 v, int i)
        {
            return (
                v.x <= i &&
                v.y <= i &&
                v.z <= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(int i, Vector3 v)
        {
            return (
                i <= v.x &&
                i <= v.y &&
                i <= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(Vector3Int a, Vector3Int b)
        {
            return (
                a.x <= b.x &&
                a.y <= b.y &&
                a.z <= b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(Vector3Int v, float f)
        {
            return (
                v.x <= f &&
                v.y <= f &&
                v.z <= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(float f, Vector3Int v)
        {
            return (
                f <= v.x &&
                f <= v.y &&
                f <= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(Vector3Int v, int i)
        {
            return (
                v.x <= i &&
                v.y <= i &&
                v.z <= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(int i, Vector3Int v)
        {
            return (
                i <= v.x &&
                i <= v.y &&
                i <= v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(Vector4 a, Vector4 b)
        {
            return (
                a.x <= b.x &&
                a.y <= b.y &&
                a.z <= b.z &&
                a.w <= b.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(Vector4 v, float f)
        {
            return (
                v.x <= f &&
                v.y <= f &&
                v.z <= f &&
                v.w <= f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(float f, Vector4 v)
        {
            return (
                f <= v.x &&
                f <= v.y &&
                f <= v.z &&
                f <= v.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(Vector4 v, int i)
        {
            return (
                v.x <= i &&
                v.y <= i &&
                v.z <= i &&
                v.w <= i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLesserOrEqual(int i, Vector4 v)
        {
            return (
                i <= v.x &&
                i <= v.y &&
                i <= v.z &&
                i <= v.w
            );
        }
        #endregion
    }
}