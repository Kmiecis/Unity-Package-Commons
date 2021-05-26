using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static partial class Mathx
    {
        #region ADD
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(Vector2 a, Vector2 b)
        {
            return new Vector2(
                a.x + b.x,
                a.y + b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(Vector2 v, float f)
        {
            return new Vector2(
                v.x + f,
                v.y + f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(float f, Vector2 v)
        {
            return new Vector2(
                f + v.x,
                f + v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(Vector2 v, int i)
        {
            return new Vector2(
                v.x + i,
                v.y + i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(int i, Vector2 v)
        {
            return new Vector2(
                i + v.x,
                i + v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Add(Vector2Int a, Vector2Int b)
        {
            return new Vector2Int(
                a.x + b.x,
                a.y + b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(Vector2Int v, float f)
        {
            return new Vector2(
                v.x + f,
                v.y + f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(float f, Vector2Int v)
        {
            return new Vector2(
                f + v.x,
                f + v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Add(Vector2Int v, int i)
        {
            return new Vector2Int(
                v.x + i,
                v.y + i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Add(int i, Vector2Int v)
        {
            return new Vector2Int(
                i + v.x,
                i + v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            return new Vector3(
                a.x + b.x,
                a.y + b.y,
                a.z + b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(Vector3 v, float f)
        {
            return new Vector3(
                v.x + f,
                v.y + f,
                v.z + f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(float f, Vector3 v)
        {
            return new Vector3(
                f + v.x,
                f + v.y,
                f + v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(Vector3 v, int i)
        {
            return new Vector3(
                v.x + i,
                v.y + i,
                v.z + i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(int i, Vector3 v)
        {
            return new Vector3(
                i + v.x,
                i + v.y,
                i + v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Add(Vector3Int a, Vector3Int b)
        {
            return new Vector3Int(
                a.x + b.x,
                a.y + b.y,
                a.z + b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(Vector3Int v, float f)
        {
            return new Vector3(
                v.x + f,
                v.y + f,
                v.z + f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(float f, Vector3Int v)
        {
            return new Vector3(
                f + v.x,
                f + v.y,
                f + v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Add(Vector3Int v, int i)
        {
            return new Vector3Int(
                v.x + i,
                v.y + i,
                v.z + i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Add(int i, Vector3Int v)
        {
            return new Vector3Int(
                i + v.x,
                i + v.y,
                i + v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Add(Vector4 a, Vector4 b)
        {
            return new Vector4(
                a.x + b.x,
                a.y + b.y,
                a.z + b.z,
                a.w + b.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Add(Vector4 v, float f)
        {
            return new Vector4(
                v.x + f,
                v.y + f,
                v.z + f,
                v.w + f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Add(float f, Vector4 v)
        {
            return new Vector4(
                f + v.x,
                f + v.y,
                f + v.z,
                f + v.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Add(Vector4 v, int i)
        {
            return new Vector4(
                v.x + i,
                v.y + i,
                v.z + i,
                v.w + i
            );
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Add(int i, Vector4 v)
        {
            return new Vector4(
                i + v.x,
                i + v.y,
                i + v.z,
                i + v.w
            );
        }
        #endregion
        
        #region SUBTRACT
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Subtract(Vector2 a, Vector2 b)
        {
            return new Vector2(
                a.x - b.x,
                a.y - b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Subtract(Vector2 v, float f)
        {
            return new Vector2(
                v.x - f,
                v.y - f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Subtract(float f, Vector2 v)
        {
            return new Vector2(
                f - v.x,
                f - v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Subtract(Vector2 v, int i)
        {
            return new Vector2(
                v.x - i,
                v.y - i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Subtract(int i, Vector2 v)
        {
            return new Vector2(
                i - v.x,
                i - v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Subtract(Vector2Int a, Vector2Int b)
        {
            return new Vector2Int(
                a.x - b.x,
                a.y - b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Subtract(Vector2Int v, float f)
        {
            return new Vector2(
                v.x - f,
                v.y - f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Subtract(float f, Vector2Int v)
        {
            return new Vector2(
                f - v.x,
                f - v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Subtract(Vector2Int v, int i)
        {
            return new Vector2Int(
                v.x - i,
                v.y - i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Subtract(int i, Vector2Int v)
        {
            return new Vector2Int(
                i - v.x,
                i - v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Subtract(Vector3 a, Vector3 b)
        {
            return new Vector3(
                a.x - b.x,
                a.y - b.y,
                a.z - b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Subtract(Vector3 v, float f)
        {
            return new Vector3(
                v.x - f,
                v.y - f,
                v.z - f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Subtract(float f, Vector3 v)
        {
            return new Vector3(
                f - v.x,
                f - v.y,
                f - v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Subtract(Vector3 v, int i)
        {
            return new Vector3(
                v.x - i,
                v.y - i,
                v.z - i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Subtract(int i, Vector3 v)
        {
            return new Vector3(
                i - v.x,
                i - v.y,
                i - v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Subtract(Vector3Int a, Vector3Int b)
        {
            return new Vector3Int(
                a.x - b.x,
                a.y - b.y,
                a.z - b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Subtract(Vector3Int v, float f)
        {
            return new Vector3(
                v.x - f,
                v.y - f,
                v.z - f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Subtract(float f, Vector3Int v)
        {
            return new Vector3(
                f - v.x,
                f - v.y,
                f - v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Subtract(Vector3Int v, int i)
        {
            return new Vector3Int(
                v.x - i,
                v.y - i,
                v.z - i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Subtract(int i, Vector3Int v)
        {
            return new Vector3Int(
                i - v.x,
                i - v.y,
                i - v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Subtract(Vector4 a, Vector4 b)
        {
            return new Vector4(
                a.x - b.x,
                a.y - b.y,
                a.z - b.z,
                a.w - b.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Subtract(Vector4 v, float f)
        {
            return new Vector4(
                v.x - f,
                v.y - f,
                v.z - f,
                v.w - f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Subtract(float f, Vector4 v)
        {
            return new Vector4(
                f - v.x,
                f - v.y,
                f - v.z,
                f - v.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Subtract(Vector4 v, int i)
        {
            return new Vector4(
                v.x - i,
                v.y - i,
                v.z - i,
                v.w - i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Subtract(int i, Vector4 v)
        {
            return new Vector4(
                i - v.x,
                i - v.y,
                i - v.z,
                i - v.w
            );
        }
        #endregion

        #region MULTIPLY
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Multiply(Vector2 a, Vector2 b)
        {
            return new Vector2(
                a.x * b.x,
                a.y * b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Multiply(Vector2 v, float f)
        {
            return new Vector2(
                v.x * f,
                v.y * f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Multiply(float f, Vector2 v)
        {
            return new Vector2(
                f * v.x,
                f * v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Multiply(Vector2 v, int i)
        {
            return new Vector2(
                v.x * i,
                v.y * i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Multiply(int i, Vector2 v)
        {
            return new Vector2(
                i * v.x,
                i * v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Multiply(Vector2Int a, Vector2Int b)
        {
            return new Vector2Int(
                a.x * b.x,
                a.y * b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Multiply(Vector2Int v, float f)
        {
            return new Vector2(
                v.x * f,
                v.y * f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Multiply(float f, Vector2Int v)
        {
            return new Vector2(
                f * v.x,
                f * v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Multiply(Vector2Int v, int i)
        {
            return new Vector2Int(
                v.x * i,
                v.y * i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Multiply(int i, Vector2Int v)
        {
            return new Vector2Int(
                i * v.x,
                i * v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Multiply(Vector3 a, Vector3 b)
        {
            return new Vector3(
                a.x * b.x,
                a.y * b.y,
                a.z * b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Multiply(Vector3 v, float f)
        {
            return new Vector3(
                v.x * f,
                v.y * f,
                v.z * f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Multiply(float f, Vector3 v)
        {
            return new Vector3(
                f * v.x,
                f * v.y,
                f * v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Multiply(Vector3 v, int i)
        {
            return new Vector3(
                v.x * i,
                v.y * i,
                v.z * i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Multiply(int i, Vector3 v)
        {
            return new Vector3(
                i * v.x,
                i * v.y,
                i * v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Multiply(Vector3Int a, Vector3Int b)
        {
            return new Vector3Int(
                a.x * b.x,
                a.y * b.y,
                a.z * b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Multiply(Vector3Int v, float f)
        {
            return new Vector3(
                v.x * f,
                v.y * f,
                v.z * f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Multiply(float f, Vector3Int v)
        {
            return new Vector3(
                f * v.x,
                f * v.y,
                f * v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Multiply(Vector3Int v, int i)
        {
            return new Vector3Int(
                v.x * i,
                v.y * i,
                v.z * i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Multiply(int i, Vector3Int v)
        {
            return new Vector3Int(
                i * v.x,
                i * v.y,
                i * v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Multiply(Vector4 a, Vector4 b)
        {
            return new Vector4(
                a.x * b.x,
                a.y * b.y,
                a.z * b.z,
                a.w * b.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Multiply(Vector4 v, float f)
        {
            return new Vector4(
                v.x * f,
                v.y * f,
                v.z * f,
                v.w * f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Multiply(float f, Vector4 v)
        {
            return new Vector4(
                f * v.x,
                f * v.y,
                f * v.z,
                f * v.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Multiply(Vector4 v, int i)
        {
            return new Vector4(
                v.x * i,
                v.y * i,
                v.z * i,
                v.w * i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Multiply(int i, Vector4 v)
        {
            return new Vector4(
                i * v.x,
                i * v.y,
                i * v.z,
                i * v.w
            );
        }
        #endregion

        #region DIVIDE
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Divide(Vector2 a, Vector2 b)
        {
            return new Vector2(
                a.x / b.x,
                a.y / b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Divide(Vector2 v, float f)
        {
            return new Vector2(
                v.x / f,
                v.y / f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Divide(float f, Vector2 v)
        {
            return new Vector2(
                f / v.x,
                f / v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Divide(Vector2 v, int i)
        {
            return new Vector2(
                v.x / i,
                v.y / i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Divide(int i, Vector2 v)
        {
            return new Vector2(
                i / v.x,
                i / v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Divide(Vector2Int a, Vector2Int b)
        {
            return new Vector2Int(
                a.x / b.x,
                a.y / b.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Divide(Vector2Int v, float f)
        {
            return new Vector2(
                v.x / f,
                v.y / f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Divide(float f, Vector2Int v)
        {
            return new Vector2(
                f / v.x,
                f / v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Divide(Vector2Int v, int i)
        {
            return new Vector2Int(
                v.x / i,
                v.y / i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Divide(int i, Vector2Int v)
        {
            return new Vector2Int(
                i / v.x,
                i / v.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Divide(Vector3 a, Vector3 b)
        {
            return new Vector3(
                a.x / b.x,
                a.y / b.y,
                a.z / b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Divide(Vector3 v, float f)
        {
            return new Vector3(
                v.x / f,
                v.y / f,
                v.z / f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Divide(float f, Vector3 v)
        {
            return new Vector3(
                f / v.x,
                f / v.y,
                f / v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Divide(Vector3 v, int i)
        {
            return new Vector3(
                v.x / i,
                v.y / i,
                v.z / i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Divide(int i, Vector3 v)
        {
            return new Vector3(
                i / v.x,
                i / v.y,
                i / v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Divide(Vector3Int a, Vector3Int b)
        {
            return new Vector3Int(
                a.x / b.x,
                a.y / b.y,
                a.z / b.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Divide(Vector3Int v, float f)
        {
            return new Vector3(
                v.x / f,
                v.y / f,
                v.z / f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Divide(float f, Vector3Int v)
        {
            return new Vector3(
                f / v.x,
                f / v.y,
                f / v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Divide(Vector3Int v, int i)
        {
            return new Vector3Int(
                v.x / i,
                v.y / i,
                v.z / i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Divide(int i, Vector3Int v)
        {
            return new Vector3Int(
                i / v.x,
                i / v.y,
                i / v.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Divide(Vector4 a, Vector4 b)
        {
            return new Vector4(
                a.x / b.x,
                a.y / b.y,
                a.z / b.z,
                a.w / b.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Divide(Vector4 v, float f)
        {
            return new Vector4(
                v.x / f,
                v.y / f,
                v.z / f,
                v.w / f
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Divide(float f, Vector4 v)
        {
            return new Vector4(
                f / v.x,
                f / v.y,
                f / v.z,
                f / v.w
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Divide(Vector4 v, int i)
        {
            return new Vector4(
                v.x / i,
                v.y / i,
                v.z / i,
                v.w / i
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Divide(int i, Vector4 v)
        {
            return new Vector4(
                i / v.x,
                i / v.y,
                i / v.z,
                i / v.w
            );
        }
        #endregion

        #region ARE_EQUAL
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(Vector2 a, Vector2 b)
        {
            return new Bool2(
                IsZero(a.x - b.x),
                IsZero(a.y - b.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(Vector2 v, float f)
        {
            return new Bool2(
                IsZero(v.x - f),
                IsZero(v.y - f)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(float f, Vector2 v)
        {
            return new Bool2(
                IsZero(f - v.x),
                IsZero(f - v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(Vector2 v, int i)
        {
            return new Bool2(
                IsZero(v.x - i),
                IsZero(v.y - i)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(int i, Vector2 v)
        {
            return new Bool2(
                IsZero(i - v.x),
                IsZero(i - v.y)
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
        public static Bool2 AreEqual(Vector2Int v, float f)
        {
            return new Bool2(
                IsZero(v.x - f),
                IsZero(v.y - f)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 AreEqual(float f, Vector2Int v)
        {
            return new Bool2(
                IsZero(f - v.x),
                IsZero(f - v.y)
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
        public static Bool3 AreEqual(Vector3 a, Vector3 b)
        {
            return new Bool3(
                IsZero(a.x - b.x),
                IsZero(a.y - b.y),
                IsZero(a.z - b.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreEqual(Vector3 v, float f)
        {
            return new Bool3(
                IsZero(v.x - f),
                IsZero(v.y - f),
                IsZero(v.z - f)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreEqual(float f, Vector3 v)
        {
            return new Bool3(
                IsZero(f - v.x),
                IsZero(f - v.y),
                IsZero(f - v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreEqual(Vector3 v, int i)
        {
            return new Bool3(
                IsZero(v.x - i),
                IsZero(v.y - i),
                IsZero(v.z - i)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreEqual(int i, Vector3 v)
        {
            return new Bool3(
                IsZero(i - v.x),
                IsZero(i - v.y),
                IsZero(i - v.z)
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
        public static Bool3 AreEqual(Vector3Int v, float f)
        {
            return new Bool3(
                IsZero(v.x - f),
                IsZero(v.y - f),
                IsZero(v.z - f)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 AreEqual(float f, Vector3Int v)
        {
            return new Bool3(
                IsZero(f - v.x),
                IsZero(f - v.y),
                IsZero(f - v.z)
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
        public static Bool4 AreEqual(Vector4 a, Vector4 b)
        {
            return new Bool4(
                IsZero(a.x - b.x),
                IsZero(a.y - b.y),
                IsZero(a.z - b.z),
                IsZero(a.w - b.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreEqual(Vector4 v, float f)
        {
            return new Bool4(
                IsZero(v.x - f),
                IsZero(v.y - f),
                IsZero(v.z - f),
                IsZero(v.w - f)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreEqual(float f, Vector4 v)
        {
            return new Bool4(
                IsZero(f - v.x),
                IsZero(f - v.y),
                IsZero(f - v.z),
                IsZero(f - v.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreEqual(Vector4 v, int i)
        {
            return new Bool4(
                IsZero(v.x - i),
                IsZero(v.y - i),
                IsZero(v.z - i),
                IsZero(v.w - i)
            );
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 AreEqual(int i, Vector4 v)
        {
            return new Bool4(
                IsZero(i - v.x),
                IsZero(i - v.y),
                IsZero(i - v.z),
                IsZero(i - v.w)
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
        public static bool IsEqual(float a, float b)
        {
            return IsZero(a - b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector2 a, Vector2 b)
        {
            return (
                IsZero(a.x - b.x) &&
                IsZero(a.y - b.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector2 v, float f)
        {
            return (
                IsZero(v.x - f) &&
                IsZero(v.y - f)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(float f, Vector2 v)
        {
            return (
                IsZero(f - v.x) &&
                IsZero(f - v.y)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector2 v, int i)
        {
            return (
                IsZero(v.x - i) &&
                IsZero(v.y - i)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(int i, Vector2 v)
        {
            return (
                IsZero(i - v.x) &&
                IsZero(i - v.y)
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
        public static bool IsEqual(Vector2Int v, float f)
        {
            return (
                IsZero(v.x - f) &&
                IsZero(v.y - f)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(float f, Vector2Int v)
        {
            return (
                IsZero(f - v.x) &&
                IsZero(f - v.y)
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
        public static bool IsEqual(Vector3 a, Vector3 b)
        {
            return (
                IsZero(a.x - b.x) &&
                IsZero(a.y - b.y) &&
                IsZero(a.z - b.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector3 v, float f)
        {
            return (
                IsZero(v.x - f) &&
                IsZero(v.y - f) &&
                IsZero(v.z - f)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(float f, Vector3 v)
        {
            return (
                IsZero(f - v.x) &&
                IsZero(f - v.y) &&
                IsZero(f - v.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector3 v, int i)
        {
            return (
                IsZero(v.x - i) &&
                IsZero(v.y - i) &&
                IsZero(v.z - i)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(int i, Vector3 v)
        {
            return (
                IsZero(i - v.x) &&
                IsZero(i - v.y) &&
                IsZero(i - v.z)
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
        public static bool IsEqual(Vector3Int v, float f)
        {
            return (
                IsZero(v.x - f) &&
                IsZero(v.y - f) &&
                IsZero(v.z - f)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(float f, Vector3Int v)
        {
            return (
                IsZero(f - v.x) &&
                IsZero(f - v.y) &&
                IsZero(f - v.z)
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
        public static bool IsEqual(Vector4 a, Vector4 b)
        {
            return (
                IsZero(a.x - b.x) &&
                IsZero(a.y - b.y) &&
                IsZero(a.z - b.z) &&
                IsZero(a.w - b.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector4 v, float f)
        {
            return (
                IsZero(v.x - f) &&
                IsZero(v.y - f) &&
                IsZero(v.z - f) &&
                IsZero(v.w - f)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(float f, Vector4 v)
        {
            return (
                IsZero(f - v.x) &&
                IsZero(f - v.y) &&
                IsZero(f - v.z) &&
                IsZero(f - v.w)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(Vector4 v, int i)
        {
            return (
                IsZero(v.x - i) &&
                IsZero(v.y - i) &&
                IsZero(v.z - i) &&
                IsZero(v.w - i)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(int i, Vector4 v)
        {
            return (
                IsZero(i - v.x) &&
                IsZero(i - v.y) &&
                IsZero(i - v.z) &&
                IsZero(i - v.w)
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