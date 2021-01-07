using System.Collections.Generic;
using UnityEngine;

namespace Common
{
	public static class Triangulate
	{
		/// <summary> Simple implementation of 2D triangulation by checking minimal circles not containing any point </summary>
		public static List<int> Simple(List<Vector2> points)
		{
			var ts = new List<int>();

			var normal = Vector3.up;
			for (int i = 0; i < points.Count; ++i)
			{
				var iPoint = points[i];

				for (int j = i + 1; j < points.Count; ++j)
				{
					var jPoint = points[j];

					for (int k = j + 1; k < points.Count; ++k)
					{
						var kPoint = points[k];

						if (CircleUtility.Create(iPoint, jPoint, kPoint, out Vector2 c, out float r))
						{
							bool contains = false;
							for (int l = 0; !contains && l < points.Count; ++l)
							{
								if (l == i || l == j || l == k)
								{
									continue;
								}

								contains = CircleUtility.Contains(c, r, points[l]);
							}

							if (!contains)
							{
								var dij = jPoint - iPoint;
								var djk = kPoint - jPoint;

								var triangleNormal = Vector3.Cross(dij.X_Y(), djk.X_Y());
								if (Vector3.Dot(triangleNormal, normal) > 0)
								{
									ts.Add(i);
									ts.Add(j);
									ts.Add(k);
								}
								else
								{
									ts.Add(k);
									ts.Add(j);
									ts.Add(i);
								}
							}
						}
					}
				}
			}

			return ts;
		}
	}
}