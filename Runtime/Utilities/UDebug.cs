using UnityEngine;

namespace Common
{
    public static class UDebug
    {
        private static readonly Vector4[] kUnitFrustum = new Vector4[]
        {
            new Vector4(-1.0f, -1.0f, -1.0f, 1.0f),
            new Vector4(-1.0f,  1.0f, -1.0f, 1.0f),
            new Vector4( 1.0f,  1.0f, -1.0f, 1.0f),
            new Vector4( 1.0f, -1.0f, -1.0f, 1.0f),
            new Vector4(-1.0f, -1.0f,  1.0f, 1.0f),
            new Vector4(-1.0f,  1.0f,  1.0f, 1.0f),
            new Vector4( 1.0f,  1.0f,  1.0f, 1.0f),
            new Vector4( 1.0f, -1.0f,  1.0f, 1.0f)
        };

        private static readonly Vector3[] kUnitCube = new Vector3[]
        {
            new Vector3(-0.5f, -0.5f, -0.5f),
            new Vector3(-0.5f,  0.5f, -0.5f),
            new Vector3( 0.5f,  0.5f, -0.5f),
            new Vector3( 0.5f, -0.5f, -0.5f),
            new Vector3(-0.5f, -0.5f,  0.5f),
            new Vector3(-0.5f,  0.5f,  0.5f),
            new Vector3( 0.5f,  0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f)
        };

        private static readonly Vector2[] kUnitSquare = new Vector2[]
        {
            new Vector2(-0.5f, -0.5f),
            new Vector2(-0.5f,  0.5f),
            new Vector2( 0.5f,  0.5f),
            new Vector2( 0.5f, -0.5f)
        };

        private static readonly Vector3[] kUnitSphere = MakeUnitSphere(32);

        private static readonly Vector2[] kUnitCircle = MakeUnitCircle(32);

        public static void DrawArrow(Vector3 position, Vector3 vector, Color color)
        {
            const float ARROW_ANGLE = 15.0f;
            const float ARROW_LENGTH = 0.15f;

            var direction = vector.normalized;
            var left = Quaternion.LookRotation(direction) * Quaternion.Euler(0.0f, 180.0f + ARROW_ANGLE, 0.0f) * Vector3.forward;
            var right = Quaternion.LookRotation(direction) * Quaternion.Euler(0.0f, 180.0f - ARROW_ANGLE, 0.0f) * Vector3.forward;
            Debug.DrawRay(position, vector, color);
            Debug.DrawRay(position + vector, ARROW_LENGTH * left, color);
            Debug.DrawRay(position + vector, ARROW_LENGTH * right, color);
        }

        public static void DrawAxes(Vector3 position, float scale = 1.0f)
        {
            Debug.DrawLine(position, position + new Vector3(scale, 0, 0), Color.red);
            Debug.DrawLine(position, position + new Vector3(0, scale, 0), Color.green);
            Debug.DrawLine(position, position + new Vector3(0, 0, scale), Color.blue);
        }

        public static void DrawAxes(Matrix4x4 transform, float scale = 1.0f)
        {
            var p = transform * new Vector4(0, 0, 0, 1);
            var x = transform * new Vector4(scale, 0, 0, 1);
            var y = transform * new Vector4(0, scale, 0, 1);
            var z = transform * new Vector4(0, 0, scale, 1);

            Debug.DrawLine(p, x, Color.red);
            Debug.DrawLine(p, y, Color.green);
            Debug.DrawLine(p, z, Color.blue);
        }

        public static void DrawFrustum(Matrix4x4 projection)
        {
            DrawFrustum(projection, Color.red, Color.magenta, Color.blue);
        }

        public static void DrawFrustum(Matrix4x4 projection, Color nearColor, Color edgeColor, Color farColor)
        {
            var vs = new Vector4[kUnitFrustum.Length];
            var m = projection.inverse;

            for (int i = 0; i < kUnitFrustum.Length; ++i)
            {
                var s = m * kUnitFrustum[i];
                vs[i] = s / s.w;
            }

            for (int i = 0; i < 4; ++i)
            {
                var start = vs[i];
                var end = vs[(i + 1) % 4];
                Debug.DrawLine(start, end, nearColor);
            }
            for (int i = 0; i < 4; ++i)
            {
                var start = vs[i];
                var end = vs[i + 4];
                Debug.DrawLine(start, end, edgeColor);
            }
            for (int i = 0; i < 4; ++i)
            {
                var start = vs[4 + i];
                var end = vs[4 + ((i + 1) % 4)];
                Debug.DrawLine(start, end, farColor);
            }
        }

        public static void DrawMarker(Vector3 position, float scale, Color color)
        {
            var sX = position + new Vector3(+scale, 0, 0);
            var eX = position + new Vector3(-scale, 0, 0);
            var sY = position + new Vector3(0, +scale, 0);
            var eY = position + new Vector3(0, -scale, 0);
            var sZ = position + new Vector3(0, 0, +scale);
            var eZ = position + new Vector3(0, 0, -scale);

            Debug.DrawLine(sX, eX, color);
            Debug.DrawLine(sY, eY, color);
            Debug.DrawLine(sZ, eZ, color);
        }

        public static void DrawWireCube(Vector3 center, Vector3 size, Color color)
        {
            var vs = kUnitCube;

            for (int i = 0; i < 4; ++i)
            {
                var start = center + Vector3.Scale(vs[i], size);
                var end = center + Vector3.Scale(vs[(i + 1) % 4], size);
                Debug.DrawLine(start, end, color);
            }
            for (int i = 0; i < 4; ++i)
            {
                var start = center + Vector3.Scale(vs[4 + i], size);
                var end = center + Vector3.Scale(vs[4 + ((i + 1) % 4)], size);
                Debug.DrawLine(start, end, color);
            }
            for (int i = 0; i < 4; ++i)
            {
                var start = center + Vector3.Scale(vs[i], size);
                var end = center + Vector3.Scale(vs[i + 4], size);
                Debug.DrawLine(start, end, color);
            }
        }

        public static void DrawWireCube(Matrix4x4 transform, Color color)
        {
            var vs = kUnitCube;
            var m = transform;

            for (int i = 0; i < 4; ++i)
            {
                var start = m * vs[i];
                var end = m * vs[(i + 1) % 4];
                Debug.DrawLine(start, end, color);
            }
            for (int i = 0; i < 4; ++i)
            {
                var start = m * vs[4 + i];
                var end = m * vs[4 + ((i + 1) % 4)];
                Debug.DrawLine(start, end, color);
            }
            for (int i = 0; i < 4; ++i)
            {
                var start = m * vs[i];
                var end = m * vs[i + 4];
                Debug.DrawLine(start, end, color);
            }
        }

        public static void DrawWireRect(Vector2 center, Vector2 size, Color color)
        {
            var vs = kUnitSquare;

            for (int i = 0; i < 4; ++i)
            {
                var start = center + Vector2.Scale(vs[i], size);
                var end = center + Vector2.Scale(vs[(i + 1) % 4], size);
                Debug.DrawLine(start, end, color);
            }
        }

        public static void DrawWireRect(Matrix4x4 transform, Color color)
        {
            var vs = kUnitSquare;
            var m = transform;

            for (int i = 0; i < 4; ++i)
            {
                var start = m * vs[i];
                var end = m * vs[(i + 1) % 4];
                Debug.DrawLine(start, end, color);
            }
        }

        public static void DrawWireSphere(Vector3 center, float radius, Color color)
        {
            var vs = kUnitSphere;
            int length = kUnitSphere.Length / 3;

            for (int i = 0; i < length; ++i)
            {
                var sX = center + radius * vs[0 * length + i];
                var eX = center + radius * vs[0 * length + (i + 1) % length];
                var sY = center + radius * vs[1 * length + i];
                var eY = center + radius * vs[1 * length + (i + 1) % length];
                var sZ = center + radius * vs[2 * length + i];
                var eZ = center + radius * vs[2 * length + (i + 1) % length];

                Debug.DrawLine(sX, eX, color);
                Debug.DrawLine(sY, eY, color);
                Debug.DrawLine(sZ, eZ, color);
            }
        }

        public static void DrawWireCircle(Vector3 center, float radius, Color color)
        {
            DrawWireCircle(center, radius, color, Vector3.forward);
        }

        public static void DrawWireCircle(Vector3 center, float radius, Color color, Vector3 up)
        {
            var vs = kUnitCircle;
            var length = vs.Length;

            var rotation = Quaternion.FromToRotation(Vector3.forward, up);
            for (int i = 0; i < vs.Length; ++i)
            {
                var s = center + radius * (rotation * vs[i]);
                var e = center + radius * (rotation * vs[(i + 1) % length]);

                Debug.DrawLine(s, e, color);
            }
        }

        private static Vector3[] MakeUnitSphere(int resolution)
        {
            var result = new Vector3[resolution * 3];
            for (int i = 0; i < resolution; ++i)
            {
                var f = i * 1.0f / resolution;
                var a = f * Mathf.PI * 2.0f;
                var x = Mathf.Cos(a);
                var y = Mathf.Sin(a);
                result[0 * resolution + i] = new Vector3(x, y, 0.0f);
                result[1 * resolution + i] = new Vector3(0.0f, x, y);
                result[2 * resolution + i] = new Vector3(y, 0.0f, x);
            }
            return result;
        }

        private static Vector2[] MakeUnitCircle(int resolution)
        {
            var result = new Vector2[resolution];
            for (int i = 0; i < resolution; ++i)
            {
                var f = i * 1.0f / resolution;
                var a = f * Mathf.PI * 2.0f;
                var x = Mathf.Cos(a);
                var y = Mathf.Sin(a);
                result[i] = new Vector2(x, y);
            }
            return result;
        }
    }
}
