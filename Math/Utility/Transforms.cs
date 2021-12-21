using UnityEngine;

namespace Common
{
    public static class Transforms
    {
        public static Vector2[] Translate(this Vector2[] vs, float x, float y)
        {
            for (int i = 0; i < vs.Length; ++i)
            {
                var v = vs[i];
                v.x += x;
                v.y += y;
                vs[i] = v;
            }
            return vs;
        }

        public static Vector2[] Rotate(this Vector2[] vs, float a)
        {
            for (int i = 0; i < vs.Length; ++i)
            {
                var v = vs[i];
                v = Mathx.Rotate(v, a);
                vs[i] = v;
            }
            return vs;
        }

        public static Vector2[] Scale(this Vector2[] vs, float w, float h)
        {
            for (int i = 0; i < vs.Length; ++i)
            {
                var v = vs[i];
                v.x *= w;
                v.y *= h;
                vs[i] = v;
            }
            return vs;
        }

        public static Vector3[] Translate(this Vector3[] vs, float x, float y, float z)
        {
            for (int i = 0; i < vs.Length; ++i)
            {
                var v = vs[i];
                v.x += x;
                v.y += y;
                v.z += z;
                vs[i] = v;
            }
            return vs;
        }

        public static Vector3[] Rotate(this Vector3[] vs, float x, float y, float z)
        {
            for (int i = 0; i < vs.Length; ++i)
            {
                var v = vs[i];
                v = Mathx.Rotate(v, x, y, z);
                vs[i] = v;
            }
            return vs;
        }

        public static Vector3[] Scale(this Vector3[] vs, float w, float h, float d)
        {
            for (int i = 0; i < vs.Length; ++i)
            {
                var v = vs[i];
                v.x *= w;
                v.y *= h;
                v.z *= d;
                vs[i] = v;
            }
            return vs;
        }
    }
}
