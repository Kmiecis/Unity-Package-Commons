using Common.Extensions;
using UnityEngine;
using Random = System.Random;

namespace Common.Mathematics
{
    public static class Noisex
    {
        public static void GetNoiseMap(
            float[][] map, int octaves = 1, float persistance = 0.5f, float lacunarity = 2.0f,
            float dx = 0.0f, float dy = 0.0f, float sx = 1.0f, float sy = 1.0f,
            Random random = null
        )
        {
            random ??= new Random();

            var width = map.GetWidth();
            var height = map.GetHeight();

            var rdx = random.NextFloat(-99999.0f, +99999.0f);
            var rdy = random.NextFloat(-99999.0f, +99999.0f);

            var fx = 1.0f / (sx * width);
            var fy = 1.0f / (sy * height);

            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    float amplitude = 1.0f;
                    float frequency = 1.0f;
                    float value = 0.0f;

                    for (int i = 0; i < octaves; ++i)
                    {
                        float sampleX = ((x - dx) * fx) * frequency + rdx;
                        float sampleY = ((y - dy) * fy) * frequency + rdy;

                        float pv = Mathf.PerlinNoise(sampleX, sampleY);
                        value += pv * amplitude;

                        amplitude *= persistance;
                        frequency *= lacunarity;
                    }

                    map[x][y] = value;
                }
            }
        }

        public static void SmoothNoiseMap(float[][] map, int octaves = 1, float persistance = 0.5f)
        {
            var width = map.GetWidth();
            var height = map.GetHeight();

            var pmin = 0.0f;
            var pmax = 1.0f;
            for (uint i = 1; i < octaves; ++i)
            {
                var ppow = Mathx.Pow(persistance, i);
                pmin += ppow * 0.25f;
                pmax += ppow * 0.75f;
            }

            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    map[x][y] = Mathf.SmoothStep(pmin, pmax, map[x][y]);
                }
            }
        }

        public static void GetNoiseMap(
            float[][][] map, int octaves = 1, float persistance = 0.5f, float lacunarity = 2.0f,
            float dx = 0.0f, float dy = 0.0f, float dz = 0.0f, float sx = 1.0f, float sy = 1.0f, float sz = 1.0f,
            Random random = null
        )
        {
            random ??= new Random();

            var width = map.GetWidth();
            var height = map.GetHeight();
            var depth = map.GetDepth();

            var rdx = random.NextFloat(-99999.0f, +99999.0f);
            var rdy = random.NextFloat(-99999.0f, +99999.0f);
            var rdz = random.NextFloat(-99999.0f, +99999.0f);

            var fx = 1.0f / (sx * width);
            var fy = 1.0f / (sy * height);
            var fz = 1.0f / (sz * depth);

            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    for (int z = 0; z < depth; z++)
                    {
                        float amplitude = 1.0f;
                        float frequency = 1.0f;
                        float value = 0.0f;

                        for (int i = 0; i < octaves; ++i)
                        {
                            float sampleX = ((x - dx) * fx) * frequency + rdx;
                            float sampleY = ((y - dy) * fy) * frequency + rdy;
                            float sampleZ = ((z - dz) * fz) * frequency + rdz;

                            float pv = Mathx.PerlinNoise(sampleX, sampleY, sampleZ);
                            value += pv * amplitude;

                            amplitude *= persistance;
                            frequency *= lacunarity;
                        }

                        map[x][y][z] = value;
                    }
                }
            }
        }

        public static void GetRandomMap(bool[][] map, float fill = 0.5f, Random random = null)
        {
            random ??= new Random();

            var width = map.GetWidth();
            var height = map.GetHeight();

            for (int x = 0; x < width; ++x)
            {
                var mapY = map[x];

                for (int y = 0; y < height; ++y)
                {
                    var rv = random.NextFloat();
                    mapY[y] = rv < fill;
                }
            }
        }

        public static void GetRandomMap(bool[][][] map, float fill = 0.5f, Random random = null)
        {
            random ??= new Random();

            var width = map.GetWidth();
            var height = map.GetHeight();
            var depth = map.GetDepth();

            for (int x = 0; x < width; ++x)
            {
                var mapYZ = map[x];

                for (int y = 0; y < height; ++y)
                {
                    var mapZ = mapYZ[y];

                    for (int z = 0; z < depth; ++z)
                    {
                        var rv = random.NextFloat();
                        mapZ[z] = rv < fill;
                    }
                }
            }
        }

        public static void SmoothRandomMap(bool[][] map, int iterations = 5)
        {
            int width = map.GetWidth();
            int height = map.GetHeight();

            var mapRange = new Range2Int(0, 0, width - 1, height - 1);

            for (int i = 0; i < iterations; i++)
            {
                for (int x = 0; x < width; x++)
                {
                    var mapY = map[x];

                    for (int y = 0; y < height; y++)
                    {
                        int counter = 0;

                        for (int dx = x - 1; dx <= x + 1; dx++)
                        {
                            for (int dy = y - 1; dy <= y + 1; dy++)
                            {
                                if (dx == x && dy == y)
                                    continue;

                                if (!mapRange.Contains(dx, dy) || map[dx][dy])
                                    counter += 1;
                            }
                        }

                        if (counter != 4)
                        {
                            mapY[y] = counter > 4;
                        }
                    }
                }
            }
        }

        public static void SmoothRandomMap(bool[][][] map, int iterations = 5)
        {
            int width = map.GetWidth();
            int height = map.GetHeight();
            int depth = map.GetDepth();

            var mapRange = new Range3Int(0, 0, 0, width - 1, height - 1, depth - 1);

            for (int i = 0; i < iterations; i++)
            {
                for (int x = 0; x < width; x++)
                {
                    var mapYZ = map[x];
                    for (int y = 0; y < height; y++)
                    {
                        var mapZ = mapYZ[y];
                        for (int z = 0; z < depth; z++)
                        {
                            int counter = 0;

                            for (int dx = x - 1; dx <= x + 1; dx++)
                            {
                                for (int dy = y - 1; dy <= y + 1; dy++)
                                {
                                    for (int dz = z - 1; dz <= z + 1; dz++)
                                    {
                                        if (dx == x && dy == y && dz == z)
                                            continue;

                                        if (!mapRange.Contains(dx, dy, dz) || map[dx][dy][dz])
                                            counter += 1;
                                    }
                                }
                            }

                            if (counter < 9)
                            {
                                mapZ[z] = false;
                            }
                            else if (counter > 16)
                            {
                                mapZ[z] = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
