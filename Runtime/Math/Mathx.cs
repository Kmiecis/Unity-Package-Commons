using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static partial class Mathx
    {
        private const float kEpsilon = 1e-6f;

        public const float ROOT_2 = 1.41421356237f;
        public const float ROOT_3 = 1.73205080757f;
        public const float ROOT_5 = 2.23606797750f;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToDegrees(float radians)
        {
            return radians * Mathf.Rad2Deg;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToRadians(float degrees)
        {
            return degrees * Mathf.Deg2Rad;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(float f, float e = kEpsilon)
        {
            return Mathf.Abs(f) < e;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(int i)
        {
            return i == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOne(float f, float e = kEpsilon)
        {
            return IsZero(f - 1.0f, e);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOne(int i)
        {
            return i == 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsValid(float f)
        {
            return !float.IsNaN(f) && !float.IsInfinity(f);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsBit(int value, int bit)
        {
            return (value & bit) == bit;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasBit(int value, int bit)
        {
            return (value & bit) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SetBit(int value, int bit)
        {
            return value |= bit;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ClearBit(int value, int bit)
        {
            return value &= ~bit;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ClampByte(int value)
        {
            return (byte)Mathf.Clamp(value, 0, byte.MaxValue);
        }


        public static float ClampLerped(float f, float min, float max, float t)
        {
            t = Mathf.Clamp(t, 0.0f, 1.0f);
            if (f < min)
                return Lerp(f, min, t);
            if (f > max)
                return Lerp(f, max, t);
            return f;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Lerp(float a, float b, float t)
        {
            return a + (b - a) * t;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InverseLerp(float a, float b, float t)
        {
            return (t - a) / (b - a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Remap(float fromMin, float fromMax, float toMin, float toMax, float v)
        {
            return Lerp(toMin, toMax, InverseLerp(fromMin, fromMax, v));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Square(float f)
        {
            return f * f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Square(int i)
        {
            return i * i;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(float f)
        {
            return (f >= 0.0f) ? 1 : -1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(int i)
        {
            return (i >= 0) ? 1 : -1;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Wrap(float f, float min, float max)
        {
            float delta = max - min;
            return Mod((Mod(f - min, delta) + delta), delta) + min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Wrap(int i, int min, int max)
        {
            int delta = max - min;
            return (((i - min) % delta) + delta) % delta + min;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Saturate(float f)
        {
            return Mathf.Clamp(f, 0.0f, 1.0f);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SmoothStep(float f)
        {
            return f * f * (3 - 2 * f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SmoothStep(float a, float b, float t)
        {
            return Lerp(a, b, SmoothStep(t));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SmootherStep(float f)
        {
            return f * f * f * (f * (f * 6 - 15) + 10);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SmootherStep(float a, float b, float t)
        {
            return Lerp(a, b, SmootherStep(t));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInRange(float f, float min, float max)
        {
            return min <= f && f <= max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInRange(int i, int min, int max)
        {
            return min <= i && i <= max;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEven(int i)
        {
            return (i % 2) == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOdd(int i)
        {
            return (i % 2) == 1;
        }


        /// <summary> Calculates array index from 'x' and 'y' coords with width 'w' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToIndex(int x, int y, int w)
        {
            return x + y * w;
        }

        /// <summary> Calculates array index from 'x', 'y' and 'z' coords with width 'w' and height 'h' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToIndex(int x, int y, int z, int w, int h)
        {
            return x + (y + z * h) * w;
        }

        /// <summary> Calculates 'x' and 'y' coords from array index with width 'w' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void FromIndex(int i, int w, out int x, out int y)
        {
            x = i % w;
            y = i / w;
        }

        /// <summary> Calculates 'x', 'y' and 'z' coords from array index with width 'w' and height 'h' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void FromIndex(int i, int w, int h, out int x, out int y, out int z)
        {
            x = i % w;
            y = (i / w) % h;
            z = i / (w * h);
        }

        /// <summary> Calculates index wrapped around by 'count' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrapIndex(int i, int count)
        {
            return Wrap(i, 0, count);
        }

        /// <summary> Calculates next index wrapped around by 'count' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int NextIndex(int i, int count)
        {
            return (i + 1) % count;
        }

        /// <summary> Calculates incremented index by 'offset' and wrapped around by 'count' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int IncrIndex(int i, int count, int offset)
        {
            return (i + offset) % count;
        }

        /// <summary> Calculates previous index wrapped around by 'count' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int PrevIndex(int i, int count)
        {
            return (i - 1 + count) % count;
        }

        /// <summary> Calculates decremented index by 'offset' and wrapped around by 'count' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int DecrIndex(int i, int count, int offset)
        {
            return (i - offset + count) % count;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Reciprocal(float f)
        {
            return 1.0f / f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ReciprocalSafe(float f)
        {
            return Reciprocal(Mathf.Max(f, kEpsilon));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(float f, int d)
        {
            return (float)Math.Round(f, d);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CeilToIntSafe(float f, int d)
        {
            int s = (int)Math.Pow(10, d);
            return Mathf.CeilToInt(f * s) / s;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int FloorToIntSafe(float f, int d)
        {
            int s = (int)Math.Pow(10, d);
            return Mathf.FloorToInt(f * s) / s;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RoundToIntSafe(float f, int d)
        {
            int s = (int)Math.Pow(10, d);
            return Mathf.RoundToInt(f * s) / s;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float CeilTo(float f, float s)
        {
            return Mathf.Ceil(f / s) * s;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float FloorTo(float f, float s)
        {
            return Mathf.Floor(f / s) * s;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float RoundTo(float f, float s)
        {
            return Mathf.Round(f / s) * s;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Select(float a, float b, bool c)
        {
            return c ? b : a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Select(int a, int b, bool c)
        {
            return c ? b : a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Select01(bool b)
        {
            return Select(0, 1, b);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Step(float a, float b)
        {
            return Select(0.0f, 1.0f, b >= a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Step(int a, int b)
        {
            return Select(0, 1, b >= a);
        }


        /// <summary> Returns the fractional part of a float value </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Frac(float f)
        {
            return f - Mathf.Floor(f);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Mod(float f, float m)
        {
            return f - m * Mathf.Floor(f / m);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Permute(float f, float p, float m)
        {
            return Mod((p * f + 1.0f) * f, m);
        }


        /// <summary> Returns f raised to power p </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Pow(float f, uint p)
        {
            float r = 1.0f;
            while (p > 0)
            {
                if ((p & 1) != 0)
                {
                    r *= f;
                }
                p >>= 1;
                f *= f;
            }
            return r;
        }

        /// <summary> Returns i raised to power p </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Pow(int i, uint p)
        {
            int r = 1;
            while (p > 0)
            {
                if ((p & 1) != 0)
                {
                    r *= i;
                }
                p >>= 1;
                i *= i;
            }
            return r;
        }


        /// <summary> Calculates determinant of an [n,n] matrix </summary>
        public static float Determinant(float[,] a)
        {
            var n = a.GetLength(0);
            if (n == 2)
            {
                return a[0, 0] * a[1, 1] - a[1, 0] * a[0, 1];
            }
            else
            {
                float[,] m = new float[n - 1, n - 1];

                float d = 0.0f;
                for (int c1 = 0; c1 < n; c1++)
                {
                    for (int i = 1; i < n; i++)
                    {
                        int c2 = 0;
                        for (int j = 0; j < n; j++)
                        {
                            if (j == c1)
                                continue;

                            m[i - 1, c2] = a[i, j];
                            c2++;
                        }
                    }

                    d = d + Mathf.Pow(-1.0f, c1) * a[0, c1] * Determinant(m);
                }
                return d;
            }
        }


        /// <summary> Calculates size of an object within field of view of 'angle' at 'distance' </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SizeAtDistance(float angle, float distance)
        {
            return 2.0f * distance * Mathf.Tan(angle * 0.5f * Mathf.Deg2Rad);
        }
    }
}
