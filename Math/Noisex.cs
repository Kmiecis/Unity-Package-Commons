using UnityEngine;
using Random = System.Random;

namespace Common.Mathematics
{
	public static class Noisex
	{
		/// <summary> Noise Map generator </summary>
		public static float[,] Map(
			Vector2Int extents, Vector2Int offset = default,
			int octaves = 1, float persistance = 0.5f, float lacunarity = 2.0f,
			Vector2 scale = default, int seed = 0
		)
		{
			var map = new float[extents.x, extents.y];
			var random = new Random(seed);

			var randomOffset = new Vector2(random.NextFloat(-99999.0f, +99999.0f), random.NextFloat(-99999.0f, +99999.0f));
			var middleOffset = Mathx.Multiply(extents, 0.5f);
			var reciprocalExtents = Mathx.Reciprocal(extents);
			var reciprocalScale = Mathx.Reciprocal(Vector2.Max(scale, new Vector2(1e-5f, 1e-5f)));

			for (int y = 0; y < extents.y; ++y)
			{
				for (int x = 0; x < extents.x; ++x)
				{
					float amplitude = 1.0f;
					float frequency = 1.0f;
					float value = 0.0f;

					for (int i = 0; i < octaves; ++i)
					{
						float sampleX = ((x - middleOffset.x + offset.x) * reciprocalScale.x * reciprocalExtents.x) * frequency + randomOffset.x;
						float sampleY = ((y - middleOffset.y + offset.y) * reciprocalScale.y * reciprocalExtents.y) * frequency + randomOffset.y;

						float perlinValue = Mathf.PerlinNoise(sampleX, sampleY);
						value += perlinValue * amplitude;

						amplitude *= persistance;
						frequency *= lacunarity;
					}

					map[x, y] = value;
				}
			}

			return map;
		}

		/// <summary> Noise Map generator smoothed to [0 .. 1] values </summary>
		public static float[,] SmoothMap(
			Vector2Int extents, Vector2Int offset = default,
			int octaves = 1, float persistance = 0.5f, float lacunarity = 2.0f,
			Vector2 scale = default, int seed = 0
		)
		{
			var map = new float[extents.x, extents.y];
			var random = new Random(seed);

			var noiseHeightMinMax = new Vector2(0.0f, 1.0f);
			for (int i = 1; i < octaves; ++i)
			{
				float persistanceAffection = Mathf.Pow(persistance, i);
				noiseHeightMinMax.x += persistanceAffection * 0.25f;
				noiseHeightMinMax.y += persistanceAffection * 0.75f;
			}

			var randomOffset = new Vector2(random.NextFloat(-99999.0f, +99999.0f), random.NextFloat(-99999.0f, +99999.0f));
			var middleOffset = Mathx.Multiply(extents, 0.5f);
			var revertedExtents = Mathx.Reciprocal(extents);
			var revertedScale = Mathx.Reciprocal(Vector2.Max(scale, new Vector2(1e-5f, 1e-5f)));

			for (int y = 0; y < extents.y; ++y)
			{
				for (int x = 0; x < extents.x; ++x)
				{
					float amplitude = 1.0f;
					float frequency = 1.0f;
					float value = 0.0f;

					for (int i = 0; i < octaves; ++i)
					{
						float sampleX = ((x - middleOffset.x + offset.x) * revertedScale.x * revertedExtents.x) * frequency + randomOffset.x;
						float sampleY = ((y - middleOffset.y + offset.y) * revertedScale.y * revertedExtents.y) * frequency + randomOffset.y;

						float perlinValue = Mathf.PerlinNoise(sampleX, sampleY);
						value += perlinValue * amplitude;

						amplitude *= persistance;
						frequency *= lacunarity;
					}

					map[x, y] = Mathf.SmoothStep(noiseHeightMinMax.x, noiseHeightMinMax.y, value);
				}
			}

			return map;
		}

		/// <summary> Noise Map generator smoothed to [0 .. 1] values </summary>
		public static bool[,] RandomMap(Vector2Int extents, float fill = 0.5f, int smooths = 5, int seed = 0)
		{
			var map = new bool[extents.x, extents.y];
			var random = new Random(seed);

			for (int y = 0; y < extents.y; ++y)
			{
				for (int x = 0; x < extents.x; ++x)
				{
					var randomValue = random.NextFloat();
					map[x, y] = randomValue < fill;
				}
			}

			var smoothMap = new bool[extents.x, extents.y];
			for (int i = 0; i < smooths; ++i)
			{
				for (int y = 0; y < extents.y; ++y)
				{
					for (int x = 0; x < extents.x; ++x)
					{
						int counter = 0;

						int dyMin = Mathf.Max(y - 1, 0);
						int dyMax = Mathf.Min(y + 1, extents.y - 1);
						for (int dy = dyMin; dy <= dyMax; ++dy)
						{
							int dxMin = Mathf.Max(x - 1, 0);
							int dxMax = Mathf.Min(x + 1, extents.x - 1);
							for (int dx = dxMin; dx <= dxMax; ++dx)
							{
								if (dx == x && dy == y)
								{
									continue;
								}

								if (map[dx, dy])
								{
									counter += 1;
								}
							}
						}

						smoothMap[x, y] = counter > 4;
					}
				}

				Utility.Swap(ref map, ref smoothMap);
			}

			return map;
		}
	}
}