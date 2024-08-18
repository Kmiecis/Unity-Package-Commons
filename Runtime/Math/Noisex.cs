using Common.Extensions;
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

                            float pv = Mathx.PerlinNoise(sampleX, sampleY, sampleZ);
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
    }
}
