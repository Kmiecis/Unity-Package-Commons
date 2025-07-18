using System.Runtime.CompilerServices;
using UnityEngine;
using Random = System.Random;

namespace Common.Mathematics
{
    public static class Noisex
    {
        public static float GetNoiseValue(
            float x, float y,
            int octaves = 1, float persistance = 0.5f, float lacunarity = 2.0f,
            float sx = 1.0f, float sy = 1.0f
        )
        {
            float amplitude = 1.0f;
            float frequency = 1.0f;
            float value = 0.0f;

            for (int _ = 0; _ < octaves; ++_)
            {
                float sampleX = (x * sx) * frequency;
                float sampleY = (y * sy) * frequency;

                float pv = Mathf.PerlinNoise(sampleX, sampleY);
                value += pv * amplitude;

                amplitude *= persistance;
                frequency *= lacunarity;
            }

            return value;
        }

        public static float SmoothNoiseValue(float value, int octaves = 1, float persistance = 0.5f)
        {
            var pmin = 0.0f;
            var pmax = 1.0f;

            for (uint i = 1; i < octaves; ++i)
            {
                var ppow = Mathx.Pow(persistance, i);
                pmin += ppow * 0.25f;
                pmax += ppow * 0.75f;
            }

            return Mathx.Remap(pmin, pmax, 0.0f, 1.0f, value);
        }

        public static void GetNoiseMap(
            float[] map, int width, int height,
            int octaves = 1, float persistance = 0.5f, float lacunarity = 2.0f,
            float dx = 0.0f, float dy = 0.0f, float sx = 1.0f, float sy = 1.0f,
            int seed = 0
        )
        {
            var random = new Random(seed);

            var rdx = random.NextFloat(-99999.0f, +99999.0f);
            var rdy = random.NextFloat(-99999.0f, +99999.0f);

            var fx = 1.0f / (sx * width);
            var fy = 1.0f / (sy * height);

            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    float amplitude = 1.0f;
                    float frequency = 1.0f;
                    float value = 0.0f;

                    for (int _ = 0; _ < octaves; ++_)
                    {
                        float sampleX = ((x - dx) * fx) * frequency + rdx;
                        float sampleY = ((y - dy) * fy) * frequency + rdy;

                        float pv = Mathf.PerlinNoise(sampleX, sampleY);
                        value += pv * amplitude;

                        amplitude *= persistance;
                        frequency *= lacunarity;
                    }

                    var i = x + y * width;
                    map[i] = value;
                }
            }
        }

        public static void SmoothNoiseMap(float[] map, int width, int height, int octaves = 1, float persistance = 0.5f)
        {
            var pmin = 0.0f;
            var pmax = 1.0f;
            for (uint i = 1; i < octaves; ++i)
            {
                var ppow = Mathx.Pow(persistance, i);
                pmin += ppow * 0.25f;
                pmax += ppow * 0.75f;
            }

            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    int index = x + y * width;
                    map[index] = Mathx.Remap(pmin, pmax, 0.0f, 1.0f, map[index]);
                }
            }
        }

        public static void GetNoiseMap(
            float[] map, int width, int height, int depth,
            int octaves = 1, float persistance = 0.5f, float lacunarity = 2.0f,
            float dx = 0.0f, float dy = 0.0f, float dz = 0.0f, float sx = 1.0f, float sy = 1.0f, float sz = 1.0f,
            int seed = 0
        )
        {
            var random = new Random(seed);

            var rdx = random.NextFloat(-99999.0f, +99999.0f);
            var rdy = random.NextFloat(-99999.0f, +99999.0f);
            var rdz = random.NextFloat(-99999.0f, +99999.0f);

            var fx = 1.0f / (sx * width);
            var fy = 1.0f / (sy * height);
            var fz = 1.0f / (sz * depth);

            for (int z = 0; z < depth; z++)
            {
                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        float amplitude = 1.0f;
                        float frequency = 1.0f;
                        float value = 0.0f;

                        for (int _ = 0; _ < octaves; ++_)
                        {
                            float sampleX = ((x - dx) * fx) * frequency + rdx;
                            float sampleY = ((y - dy) * fy) * frequency + rdy;
                            float sampleZ = ((z - dz) * fz) * frequency + rdz;

                            float pv = Noisex.PerlinNoise(sampleX, sampleY, sampleZ);
                            value += pv * amplitude;

                            amplitude *= persistance;
                            frequency *= lacunarity;
                        }

                        int i = x + (y + z * height) * width;
                        map[i] = value;
                    }
                }
            }
        }

        public static void GetRandomMap(bool[] map, int width, int height, float fill = 0.5f, int seed = 0)
        {
            var random = new Random(seed);

            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    var rv = random.NextFloat();
                    var i = x + y * width;
                    map[i] = rv < fill;
                }
            }
        }

        public static void GetRandomMap(bool[] map, int width, int height, int depth, float fill = 0.5f, int seed = 0)
        {
            var random = new Random(seed);

            for (int z = 0; z < depth; ++z)
            {
                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        var rv = random.NextFloat();
                        int i = x + (y + z * height) * width;
                        map[i] = rv < fill;
                    }
                }
            }
        }

        public static void SmoothRandomMap(bool[] map, int width, int height, int iterations = 5)
        {
            var mapRange = new Range2Int(0, 0, width - 1, height - 1);

            for (int i = 0; i < iterations; i++)
            {
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int counter = 0;

                        for (int dy = y - 1; dy <= y + 1; dy++)
                        {
                            for (int dx = x - 1; dx <= x + 1; dx++)
                            {
                                if (dx == x && dy == y)
                                {
                                    continue;
                                }

                                int di = dx + dy * width;
                                if (mapRange.Contains(dx, dy) && map[di])
                                {
                                    counter += 1;
                                }
                            }
                        }

                        if (counter != 4)
                        {
                            int m = x + y * width;
                            map[m] = counter > 4;
                        }
                    }
                }
            }
        }

        public static void SmoothRandomMap(bool[] map, int width, int height, int depth, int iterations = 5)
        {
            var mapRange = new Range3Int(0, 0, 0, width - 1, height - 1, depth - 1);

            for (int i = 0; i < iterations; i++)
            {
                for (int z = 0; z < depth; z++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            int counter = 0;

                            for (int dz = z - 1; dz <= z + 1; dz++)
                            {
                                for (int dy = y - 1; dy <= y + 1; dy++)
                                {
                                    for (int dx = x - 1; dx <= x + 1; dx++)
                                    {
                                        if (dx == x && dy == y && dz == z)
                                        {
                                            continue;
                                        }

                                        int di = dx + (dy + dz * height) * width;
                                        if (mapRange.Contains(dx, dy, dz) && map[di])
                                        {
                                            counter += 1;
                                        }
                                    }
                                }
                            }

                            int m = x + (y + z * height) * width;
                            if (counter < 9)
                            {
                                map[m] = false;
                            }
                            else if (counter > 16)
                            {
                                map[m] = true;
                            }
                        }
                    }
                }
            }
        }

        /// <summary> Calculates a perlin noise value based on 'x', 'y' and 'z' value </summary>
        public static float PerlinNoise(float x, float y, float z)
        {
            const float MOD = 289.0f;
            const float PERMUTE = 34.0f;
            const float MULTIPLIER = 2.2f;

            var p = new Vector3(x, y, z);
            var pi0 = Mathx.Floor(p); // Integer part for indexing
            var pi1 = pi0 + Vector3.one; // Integer part + 1
            pi0 = Mathx.Mod(pi0, MOD);
            pi1 = Mathx.Mod(pi1, MOD);
            var pf0 = Mathx.Frac(p); // Fractional part for interpolation
            var pf1 = pf0 - Vector3.one; // Fractional part - 1.0

            var ix = new Vector4(pi0.x, pi1.x, pi0.x, pi1.x);
            var iy = new Vector4(pi0.y, pi0.y, pi1.y, pi1.y);
            var iz0 = new Vector4(pi0.z, pi0.z, pi0.z, pi0.z);
            var iz1 = new Vector4(pi1.z, pi1.z, pi1.z, pi1.z);

            var ixy = Mathx.Permute(Mathx.Permute(ix, PERMUTE, MOD) + iy, PERMUTE, MOD);
            var ixy0 = Mathx.Permute(ixy + iz0, PERMUTE, MOD);
            var ixy1 = Mathx.Permute(ixy + iz1, PERMUTE, MOD);

            var gx0 = ixy0 * (1.0f / 7.0f);
            var gy0 = Mathx.Sub(Mathx.Frac(Mathx.Mul(Mathx.Floor(gx0), (1.0f / 7.0f))), 0.5f);
            gx0 = Mathx.Frac(gx0);
            var gz0 = Vector4.one * 0.5f - Mathx.Abs(gx0) - Mathx.Abs(gy0);
            var sz0 = Mathx.Step(gz0, Vector4.zero);
            gx0 -= Mathx.Mul(sz0, Mathx.Sub(Mathx.Step(Vector4.zero, gx0), 0.5f));
            gy0 -= Mathx.Mul(sz0, Mathx.Sub(Mathx.Step(Vector4.zero, gy0), 0.5f));

            var gx1 = ixy1 * (1.0f / 7.0f);
            var gy1 = Mathx.Sub(Mathx.Frac(Mathx.Floor(gx1) * (1.0f / 7.0f)), 0.5f);
            gx1 = Mathx.Frac(gx1);
            var gz1 = Vector4.one * 0.5f - Mathx.Abs(gx1) - Mathx.Abs(gy1);
            var sz1 = Mathx.Step(gz1, Vector4.zero);
            gx1 -= Mathx.Mul(sz1, Mathx.Sub(Mathx.Step(Vector4.zero, gx1), 0.5f));
            gy1 -= Mathx.Mul(sz1, Mathx.Sub(Mathx.Step(Vector4.zero, gy1), 0.5f));

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

            var fade_xyz = Mathx.SmootherStep(pf0);
            var n_z = Vector4.Lerp(new Vector4(n000, n100, n010, n110), new Vector4(n001, n101, n011, n111), fade_xyz.z);
            var n_yz = Vector2.Lerp(new Vector2(n_z.x, n_z.y), new Vector2(n_z.z, n_z.w), fade_xyz.y);
            float n_xyz = Mathx.Lerp(n_yz.x, n_yz.y, fade_xyz.x);

            return MULTIPLIER * n_xyz;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Vector4 TaylorInvSqrt(Vector4 v)
        {
            return Mathx.Sub(1.79284291400159f, Mathx.Mul(0.85373472095314f, v));
        }
    }
}
