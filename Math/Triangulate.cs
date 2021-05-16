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

            var normal = Vector3.back;
            for (int i = 0; i < points.Count; ++i)
            {
                var iPoint = points[i];

                for (int j = i + 1; j < points.Count; ++j)
                {
                    var jPoint = points[j];

                    for (int k = j + 1; k < points.Count; ++k)
                    {
                        var kPoint = points[k];

                        if (Circle.TryCreate(iPoint, jPoint, kPoint, out var circle))
                        {
                            bool contains = false;
                            for (int l = 0; !contains && l < points.Count; ++l)
                            {
                                if (l == i || l == j || l == k)
                                {
                                    continue;
                                }

                                contains = circle.Contains(points[l]);
                            }
                            
                            if (!contains)
                            {
                                var triangle = new Triangle { v0 = iPoint, v1 = jPoint, v2 = kPoint };
                                var triangleNormal = triangle.Normal;

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