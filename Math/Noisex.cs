using UnityEngine;
using Random = System.Random;

namespace Common
{
	public static class Noisex
	{
		public static float PerlinNoise(Vector3 p)
		{
			const float MOD = 289.0f;
			const float PERMUTE = 34.0f;

			Vector3 Pi0 = Mathx.Floor(p); // Integer part for indexing
			Vector3 Pi1 = Pi0 + Vector3.one; // Integer part + 1
			Pi0 = Mathx.Mod(Pi0, MOD);
			Pi1 = Mathx.Mod(Pi1, MOD);
			Vector3 Pf0 = Mathx.Frac(p); // Fractional part for interpolation
			Vector3 Pf1 = Pf0 - Vector3.one; // Fractional part - 1.0
			Vector4 ix = new Vector4(Pi0.x, Pi1.x, Pi0.x, Pi1.x);
			Vector4 iy = new Vector4(Pi0.y, Pi0.y, Pi1.y, Pi1.y);
			Vector4 iz0 = new Vector4(Pi0.z, Pi0.z, Pi0.z, Pi0.z);
			Vector4 iz1 = new Vector4(Pi1.z, Pi1.z, Pi1.z, Pi1.z);

			Vector4 ixy = Mathx.Permute(Mathx.Permute(ix, PERMUTE, MOD) + iy, PERMUTE, MOD);
			Vector4 ixy0 = Mathx.Permute(ixy + iz0, PERMUTE, MOD);
			Vector4 ixy1 = Mathx.Permute(ixy + iz1, PERMUTE, MOD);

			Vector4 gx0 = ixy0 * (1.0f / 7.0f);
			Vector4 gy0 = Mathx.Subtract(Mathx.Frac(Mathx.Multiply(Mathx.Floor(gx0), (1.0f / 7.0f))), 0.5f);
			gx0 = Mathx.Frac(gx0);
			Vector4 gz0 = Vector4.one * 0.5f - Mathx.Abs(gx0) - Mathx.Abs(gy0);
			Vector4 sz0 = Mathx.Step(gz0, Vector4.zero);
			gx0 -= Mathx.Multiply(sz0, Mathx.Subtract(Mathx.Step(Vector4.zero, gx0), 0.5f));
			gy0 -= Mathx.Multiply(sz0, Mathx.Subtract(Mathx.Step(Vector4.zero, gy0), 0.5f));

			Vector4 gx1 = ixy1 * (1.0f / 7.0f);
			Vector4 gy1 = Mathx.Subtract(Mathx.Frac(Mathx.Floor(gx1) * (1.0f / 7.0f)), 0.5f);
			gx1 = Mathx.Frac(gx1);
			Vector4 gz1 = Vector4.one * 0.5f - Mathx.Abs(gx1) - Mathx.Abs(gy1);
			Vector4 sz1 = Mathx.Step(gz1, Vector4.zero);
			gx1 -= Mathx.Multiply(sz1, Mathx.Subtract(Mathx.Step(Vector4.zero, gx1), 0.5f));
			gy1 -= Mathx.Multiply(sz1, Mathx.Subtract(Mathx.Step(Vector4.zero, gy1), 0.5f));

			Vector3 g000 = new Vector3(gx0.x, gy0.x, gz0.x);
			Vector3 g100 = new Vector3(gx0.y, gy0.y, gz0.y);
			Vector3 g010 = new Vector3(gx0.z, gy0.z, gz0.z);
			Vector3 g110 = new Vector3(gx0.w, gy0.w, gz0.w);
			Vector3 g001 = new Vector3(gx1.x, gy1.x, gz1.x);
			Vector3 g101 = new Vector3(gx1.y, gy1.y, gz1.y);
			Vector3 g011 = new Vector3(gx1.z, gy1.z, gz1.z);
			Vector3 g111 = new Vector3(gx1.w, gy1.w, gz1.w);

			Vector4 TaylorInvSqrt(Vector4 v)
			{
				return Mathx.Subtract(1.79284291400159f, Mathx.Multiply(0.85373472095314f, v));
			}

			Vector4 norm0 = TaylorInvSqrt(new Vector4(
				Vector3.Dot(g000, g000),
				Vector3.Dot(g010, g010),
				Vector3.Dot(g100, g100),
				Vector3.Dot(g110, g110)
			));
			g000 *= norm0.x;
			g010 *= norm0.y;
			g100 *= norm0.z;
			g110 *= norm0.w;

			Vector4 norm1 = TaylorInvSqrt(new Vector4(
				Vector3.Dot(g001, g001),
				Vector3.Dot(g011, g011),
				Vector3.Dot(g101, g101),
				Vector3.Dot(g111, g111)
			));
			g001 *= norm1.x;
			g011 *= norm1.y;
			g101 *= norm1.z;
			g111 *= norm1.w;

			float n000 = Vector3.Dot(g000, Pf0);
			float n100 = Vector3.Dot(g100, new Vector3(Pf1.x, Pf0.y, Pf0.z));
			float n010 = Vector3.Dot(g010, new Vector3(Pf0.x, Pf1.y, Pf0.z));
			float n110 = Vector3.Dot(g110, new Vector3(Pf1.x, Pf1.y, Pf0.z));
			float n001 = Vector3.Dot(g001, new Vector3(Pf0.x, Pf0.y, Pf1.z));
			float n101 = Vector3.Dot(g101, new Vector3(Pf1.x, Pf0.y, Pf1.z));
			float n011 = Vector3.Dot(g011, new Vector3(Pf0.x, Pf1.y, Pf1.z));
			float n111 = Vector3.Dot(g111, Pf1);

			Vector3 fade_xyz = Mathx.SmootherStep(Pf0);
			Vector4 n_z = Vector4.Lerp(new Vector4(n000, n100, n010, n110), new Vector4(n001, n101, n011, n111), fade_xyz.z);
			Vector2 n_yz = Vector2.Lerp(new Vector2(n_z.x, n_z.y), new Vector2(n_z.z, n_z.w), fade_xyz.y);
			float n_xyz = Mathf.Lerp(n_yz.x, n_yz.y, fade_xyz.x);
			return 2.2f * n_xyz;
		}

		/// <summary> Noise Map generator </summary>
		public static float[,] Map(
			int width, int height, int dx = 0, int dy = 0,
			int octaves = 1, float persistance = 0.5f, float lacunarity = 2.0f,
			float sx = 1.0f, float sy = 1.0f, int seed = 0
		)
		{
			var map = new float[width, height];
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

					for (int i = 0; i < octaves; ++i)
					{
						float sampleX = ((x - dx) * fx) * frequency + rdx;
						float sampleY = ((y - dy) * fy) * frequency + rdy;

						float pv = Mathf.PerlinNoise(sampleX, sampleY);
						value += pv * amplitude;

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
			int width, int height, int dx = 0, int dy = 0,
			int octaves = 1, float persistance = 0.5f, float lacunarity = 2.0f,
			float sx = 1.0f, float sy = 1.0f, int seed = 0
		)
		{
			var map = new float[width, height];
			var random = new Random(seed);

			var noiseHeightMinMax = new Vector2(0.0f, 1.0f);
			for (int i = 1; i < octaves; ++i)
			{
				float persistanceAffection = Mathf.Pow(persistance, i);
				noiseHeightMinMax.x += persistanceAffection * 0.25f;
				noiseHeightMinMax.y += persistanceAffection * 0.75f;
			}

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

					for (int i = 0; i < octaves; ++i)
					{
						float sampleX = ((x - dx) * fx) * frequency + rdx;
						float sampleY = ((y - dy) * fy) * frequency + rdy;

						float pv = Mathf.PerlinNoise(sampleX, sampleY);
						value += pv * amplitude;

						amplitude *= persistance;
						frequency *= lacunarity;
					}

					map[x, y] = Mathf.SmoothStep(noiseHeightMinMax.x, noiseHeightMinMax.y, value);
				}
			}

			return map;
		}

		/// <summary> Noise Map generator smoothed to [0 .. 1] values </summary>
		public static bool[,] RandomMap(int width, int height, float fill = 0.5f, int smooths = 5, int seed = 0)
		{
			var map = new bool[width, height];
			var random = new Random(seed);

			for (int y = 0; y < height; ++y)
			{
				for (int x = 0; x < width; ++x)
				{
					var randomValue = random.NextFloat();
					map[x, y] = randomValue < fill;
				}
			}

			for (int i = 0; i < smooths; ++i)
			{
				for (int y = 0; y < height; ++y)
				{
					for (int x = 0; x < width; ++x)
					{
						int counter = 0;

						int dyMin = Mathf.Max(y - 1, 0);
						int dyMax = Mathf.Min(y + 1, height - 1);
						for (int dy = dyMin; dy <= dyMax; ++dy)
						{
							int dxMin = Mathf.Max(x - 1, 0);
							int dxMax = Mathf.Min(x + 1, width - 1);
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

						if (counter != 4)
						{
							map[x, y] = counter > 4;
						}
					}
				}
			}

			return map;
		}
	}
}