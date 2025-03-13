using Common.Extensions;
using UnityEngine;
using UnityEngine.Rendering;

namespace Common
{
    /// <summary> Extention to GL class. Works inside OnRenderObject method or during Repaint phase. </summary>
    public static class GLx
    {
        private const float DOT_SCALER = 0.005f;

        private static readonly Vector2[] sUnitCircle = MakeUnitCircle(32);

        private static Matrix4x4 _matrix = Matrix4x4.identity;
        private static Color _color = Color.white;

        public static void ApplyMatrix(Matrix4x4 matrix) => _matrix = matrix;
        public static void ClearMatrix() => _matrix = Matrix4x4.identity;

        public static void ApplyColor(Color color) => _color = color;
        public static void ClearColor() => _color = Color.white;

        public static void ApplyZTest(CompareFunction compare) => GetMaterial().SetInt("_ZWrite", (int)compare);
        public static void ClearZTest() => GetMaterial().SetInt("_ZWrite", (int)CompareFunction.Always);

        public static void DrawLine(Vector3 v0, Vector3 v1)
        {
            if (BeginDrawing(GL.LINES))
            {
                GL.Color(_color);

                GL.Vertex(v0);
                GL.Vertex(v1);

                EndDrawing();
            }
        }

        public static void DrawLines(params Vector3[] segments)
        {
            if (BeginDrawing(GL.LINES))
            {
                GL.Color(_color);

                for (int i = 0; i < segments.Length - 1; i += 2)
                {
                    var v0 = segments[i + 0];
                    var v1 = segments[i + 1];

                    GL.Vertex(v0);
                    GL.Vertex(v1);
                }

                EndDrawing();
            }
        }

        public static void DrawPolyLine(params Vector3[] points)
        {
            if (BeginDrawing(GL.LINE_STRIP))
            {
                GL.Color(_color);

                for (int i = 0; i < points.Length; i++)
                {
                    var p = points[i];

                    GL.Vertex(p);
                }

                EndDrawing();
            }
        }

        public static void DrawPolyLine(params Vector4[] points)
        {
            if (BeginDrawing(GL.LINE_STRIP))
            {
                for (int i = 0; i < points.Length; i++)
                {
                    var p = points[i];
                    var c = _color.RGB_(p.w);

                    GL.Color(c);
                    GL.Vertex(p);
                }

                EndDrawing();
            }
        }

        public static void DrawDots(params Vector3[] vertices)
        {
            if (BeginDrawing(GL.QUADS))
            {
                GL.Color(_color);

                var camera = Camera.current;
                var position = camera ? camera.transform.position : Vector3.zero;
                var right = camera ? camera.transform.right : Vector3.right;
                var up = camera ? camera.transform.up : Vector3.up;

                for (int i = 0; i < vertices.Length; ++i)
                {
                    var v = vertices[i];
                    var s = Vector3.Distance(v, position) * DOT_SCALER;

                    var v0 = v + (right + up) * s;
                    var v1 = v + (right - up) * s;
                    var v2 = v + (-right - up) * s;
                    var v3 = v + (-right + up) * s;

                    GL.Vertex(v0);
                    GL.Vertex(v1);
                    GL.Vertex(v2);
                    GL.Vertex(v3);
                }

                EndDrawing();
            }
        }

        public static void DrawDots(params Vector4[] vertices)
        {
            if (BeginDrawing(GL.QUADS))
            {
                var camera = Camera.current;
                var position = camera ? camera.transform.position : Vector3.zero;
                var right = camera ? camera.transform.right : Vector3.right;
                var up = camera ? camera.transform.up : Vector3.up;

                for (int i = 0; i < vertices.Length; ++i)
                {
                    var vertex = vertices[i];
                    var v = vertex.XYZ();
                    var c = _color.RGB_(vertex.w);
                    var s = Vector3.Distance(v, position) * DOT_SCALER;

                    var v0 = v + (right + up) * s;
                    var v1 = v + (right - up) * s;
                    var v2 = v + (-right - up) * s;
                    var v3 = v + (-right + up) * s;

                    GL.Color(c);
                    GL.Vertex(v0);
                    GL.Vertex(v1);
                    GL.Vertex(v2);
                    GL.Vertex(v3);
                }

                EndDrawing();
            }
        }

        public static void DrawWireDisc(Vector3 center, Vector3 normal, float radius)
        {
            if (BeginDrawing(GL.LINE_STRIP))
            {
                GL.Color(_color);

                var rotation = Quaternion.FromToRotation(Vector3.forward, normal);
                for (int i = 0; i < sUnitCircle.Length; ++i)
                {
                    var pi = center + radius * (rotation * sUnitCircle[i]);

                    GL.Vertex(pi);
                }

                var p0 = center + radius * (rotation * sUnitCircle[0]);

                GL.Vertex(p0);

                EndDrawing();
            }
        }

        public static void DrawWireMesh(params Vector3[] vertices)
        {
            if (BeginDrawing(GL.LINES))
            {
                GL.Color(_color);

                for (int i = 0; i < vertices.Length - 2; i += 3)
                {
                    var v0 = vertices[i + 0];
                    var v1 = vertices[i + 1];
                    var v2 = vertices[i + 2];
                    var v3 = vertices[i + 0];

                    GL.Vertex(v0);
                    GL.Vertex(v1);
                    GL.Vertex(v2);
                    GL.Vertex(v3);
                }

                EndDrawing();
            }
        }

        public static void DrawWireMesh(params Vector4[] vertices)
        {
            if (BeginDrawing(GL.LINES))
            {
                for (int i = 0; i < vertices.Length - 2; i += 3)
                {
                    var v0 = vertices[i + 0];
                    var c0 = _color.RGB_(v0.w);
                    var v1 = vertices[i + 1];
                    var c1 = _color.RGB_(v1.w);
                    var v2 = vertices[i + 2];
                    var c2 = _color.RGB_(v2.w);
                    var v3 = vertices[i + 0];
                    var c3 = _color.RGB_(v3.w);

                    GL.Color(c0);
                    GL.Vertex(v0);

                    GL.Color(c1);
                    GL.Vertex(v1);

                    GL.Color(c2);
                    GL.Vertex(v2);

                    GL.Color(c3);
                    GL.Vertex(v3);
                }

                EndDrawing();
            }
        }

        private static bool BeginDrawing(int mode)
        {
            var material = GetMaterial();
            if (!material.SetPass(0))
                return false;

            GL.PushMatrix();
            GL.MultMatrix(_matrix);
            GL.Begin(mode);

            return true;
        }

        private static void EndDrawing()
        {
            GL.End();
            GL.PopMatrix();
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

        private static Material GetMaterial()
        {
            if (!_material)
            {
                Shader shader = Shader.Find("Hidden/Internal-Colored");
                _material = new Material(shader);
                _material.hideFlags = HideFlags.HideAndDontSave;
                // Turn on alpha blending
                _material.SetInt("_SrcBlend", (int)BlendMode.SrcAlpha);
                _material.SetInt("_DstBlend", (int)BlendMode.OneMinusSrcAlpha);
                // Turn backface culling off
                _material.SetInt("_Cull", (int)CullMode.Off);
                // Turn off depth writes
                _material.SetInt("_ZWrite", (int)CompareFunction.Always);
            }
            return _material;
        }

        private static Material _material;
    }
}