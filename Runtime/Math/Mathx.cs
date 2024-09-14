using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    public static partial class Mathx
    {
        private const float kEpsilon = 1e-7f;

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
        public static float Remap(float fromMin, float fromMax, float toMin, float toMax, float v)
        {
            return Lerp(toMin, toMax, InverseLerp(fromMin, fromMax, v));
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Vector4 TaylorInvSqrt(Vector4 v)
        {
            return Sub(1.79284291400159f, Mul(0.85373472095314f, v));
        }

        /// <summary> Calculates a perlin noise value based on 'x', 'y' and 'z' value </summary>
        public static float PerlinNoise(float x, float y, float z)
        {
            const float MOD = 289.0f;
            const float PERMUTE = 34.0f;
            const float MULTIPLIER = 2.2f;

            var p = new Vector3(x, y, z);
            var pi0 = Floor(p); // Integer part for indexing
            var pi1 = pi0 + Vector3.one; // Integer part + 1
            pi0 = Mod(pi0, MOD);
            pi1 = Mod(pi1, MOD);
            var pf0 = Frac(p); // Fractional part for interpolation
            var pf1 = pf0 - Vector3.one; // Fractional part - 1.0

            var ix = new Vector4(pi0.x, pi1.x, pi0.x, pi1.x);
            var iy = new Vector4(pi0.y, pi0.y, pi1.y, pi1.y);
            var iz0 = new Vector4(pi0.z, pi0.z, pi0.z, pi0.z);
            var iz1 = new Vector4(pi1.z, pi1.z, pi1.z, pi1.z);

            var ixy = Permute(Permute(ix, PERMUTE, MOD) + iy, PERMUTE, MOD);
            var ixy0 = Permute(ixy + iz0, PERMUTE, MOD);
            var ixy1 = Permute(ixy + iz1, PERMUTE, MOD);

            var gx0 = ixy0 * (1.0f / 7.0f);
            var gy0 = Sub(Frac(Mul(Floor(gx0), (1.0f / 7.0f))), 0.5f);
            gx0 = Frac(gx0);
            var gz0 = Vector4.one * 0.5f - Abs(gx0) - Abs(gy0);
            var sz0 = Step(gz0, Vector4.zero);
            gx0 -= Mul(sz0, Sub(Step(Vector4.zero, gx0), 0.5f));
            gy0 -= Mul(sz0, Sub(Step(Vector4.zero, gy0), 0.5f));

            var gx1 = ixy1 * (1.0f / 7.0f);
            var gy1 = Sub(Frac(Floor(gx1) * (1.0f / 7.0f)), 0.5f);
            gx1 = Frac(gx1);
            var gz1 = Vector4.one * 0.5f - Abs(gx1) - Abs(gy1);
            var sz1 = Step(gz1, Vector4.zero);
            gx1 -= Mul(sz1, Sub(Step(Vector4.zero, gx1), 0.5f));
            gy1 -= Mul(sz1, Sub(Step(Vector4.zero, gy1), 0.5f));

            var g000 = new Vector3(gx0.x, gy0.x, gz0.x);
            var g100 = new Vector3(gx0.y, gy0.y, gz0.y);
            var g010 = new Vector3(gx0.z, gy0.z, gz0.z);
            var g110 = new Vector3(gx0.w, gy0.w, gz0.w);
            var g001 = new Vector3(gx1.x, gy1.x, gz1.x);
            var g101 = new Vector3(gx1.y, gy1.y, gz1.y);
            var g011 = new Vector3(gx1.z, gy1.z, gz1.z);
            var g111 = new Vector3(gx1.w, gy1.w, gz1.w);

            var norm0 = TaylorInvSqrt(new Vector4(
                Vector3.Dot(g000, g000),
                Vector3.Dot(g010, g010),
                Vector3.Dot(g100, g100),
                Vector3.Dot(g110, g110)
            ));

            g000 *= norm0.x;
            g010 *= norm0.y;
            g100 *= norm0.z;
            g110 *= norm0.w;

            var norm1 = TaylorInvSqrt(new Vector4(
                Vector3.Dot(g001, g001),
                Vector3.Dot(g011, g011),
                Vector3.Dot(g101, g101),
                Vector3.Dot(g111, g111)
            ));

            g001 *= norm1.x;
            g011 *= norm1.y;
            g101 *= norm1.z;
            g111 *= norm1.w;

            float n000 = Vector3.Dot(g000, pf0);
            float n100 = Vector3.Dot(g100, new Vector3(pf1.x, pf0.y, pf0.z));
            float n010 = Vector3.Dot(g010, new Vector3(pf0.x, pf1.y, pf0.z));
            float n110 = Vector3.Dot(g110, new Vector3(pf1.x, pf1.y, pf0.z));
            float n001 = Vector3.Dot(g001, new Vector3(pf0.x, pf0.y, pf1.z));
            float n101 = Vector3.Dot(g101, new Vector3(pf1.x, pf0.y, pf1.z));
            float n011 = Vector3.Dot(g011, new Vector3(pf0.x, pf1.y, pf1.z));
            float n111 = Vector3.Dot(g111, pf1);

            var fade_xyz = SmootherStep(pf0);
            var n_z = Vector4.Lerp(new Vector4(n000, n100, n010, n110), new Vector4(n001, n101, n011, n111), fade_xyz.z);
            var n_yz = Vector2.Lerp(new Vector2(n_z.x, n_z.y), new Vector2(n_z.z, n_z.w), fade_xyz.y);
            float n_xyz = Lerp(n_yz.x, n_yz.y, fade_xyz.x);

            return MULTIPLIER * n_xyz;
        }
    }
}
