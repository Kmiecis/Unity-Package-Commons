using UnityEngine;

namespace Common
{
    public static class Polygons
    {
        /// <summary> Calculates distance to point 'p' from nearest point on polygon defined by vertices 'vs' </summary>
        public static float Distance(Vector2 p, params Vector2[] vs)
        {
            float min = float.MaxValue;
            float max = float.MinValue;

            for (int i0 = 0; i0 < vs.Length; ++i0)
            {
                int i1 = (i0 + 1) % vs.Length;
                var v0 = vs[i0];
                var v1 = vs[i1];

                var n = new Vector2(v1.y - v0.y, v0.x - v1.x).normalized;

                float A = Vector2.Dot(n, p);

                float minB = float.MaxValue;
                float maxB = float.MinValue;

                for (int i = 0; i < vs.Length; ++i)
                {
                    float B = Vector2.Dot(n, vs[i]);

                    minB = Mathf.Min(minB, B);
                    maxB = Mathf.Max(maxB, B);
                }

                min = Mathf.Min(min, A - maxB);
                max = Mathf.Max(max, minB - A);
            }

            return Mathf.Min(Mathf.Abs(min), Mathf.Abs(max));
        }
    }
}