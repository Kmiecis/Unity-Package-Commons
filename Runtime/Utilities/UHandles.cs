#if UNITY_EDITOR
using Common;
using Common.Extensions;
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace CommonEditor
{
    public static class UHandles
    {
        private const float PIXEL_SCALER = 0.005f;

        private static Action<CompareFunction> _ApplyWireMaterial;

        private static Action<CompareFunction> ApplyWireMaterial
            => _ApplyWireMaterial ?? (_ApplyWireMaterial = CreateApplyWireMaterialMethod());

        public static void DrawDotsAlpha(params Vector4[] vertices)
        {
            if (BeginDrawing(GL.QUADS))
            {
                var position = Camera.current == null ? Vector3.zero : Camera.current.transform.position;
                var right = Camera.current == null ? Vector3.right : Camera.current.transform.right;
                var up = Camera.current == null ? Vector3.up : Camera.current.transform.up;

                for (int i = 0; i < vertices.Length; ++i)
                {
                    var vertex = vertices[i];
                    var v = vertex.XYZ();
                    var c = Handles.color.RGB_(vertex.w);
                    var s = Vector3.Distance(v, position) * PIXEL_SCALER;

                    var v0 = v + (right + up) * s;
                    var v1 = v + (right - up) * s;
                    var v2 = v + (-right - up) * s;
                    var v3 = v + (-right + up) * s;

                    UGL.Quad(v0, v1, v2, v3, c);
                }

                EndDrawing();
            }
        }

        public static void DrawDots(params Vector3[] vertices)
        {
            if (BeginDrawing(GL.QUADS))
            {
                var c = Handles.color;

                var position = Camera.current == null ? Vector3.zero : Camera.current.transform.position;
                var right = Camera.current == null ? Vector3.right : Camera.current.transform.right;
                var up = Camera.current == null ? Vector3.up : Camera.current.transform.up;

                for (int i = 0; i < vertices.Length; ++i)
                {
                    var v = vertices[i];
                    var s = Vector3.Distance(v, position) * PIXEL_SCALER;

                    var v0 = v + (right + up) * s;
                    var v1 = v + (right - up) * s;
                    var v2 = v + (-right - up) * s;
                    var v3 = v + (-right + up) * s;

                    UGL.Quad(v0, v1, v2, v3, c);
                }

                EndDrawing();
            }
        }

        public static void DrawWireMeshAlpha(params Vector4[] vertices)
        {
            if (BeginDrawing(GL.LINES))
            {
                var c = Handles.color;

                for (int i = 0; i < vertices.Length - 2; i += 3)
                {
                    var v0 = vertices[i + 0];
                    var c0 = c.RGB_(v0.w);

                    var v1 = vertices[i + 1];
                    var c1 = c.RGB_(v1.w);

                    var v2 = vertices[i + 2];
                    var c2 = c.RGB_(v2.w);

                    UGL.LineTriangle(v0, v1, v2, c0, c1, c2);
                }

                EndDrawing();
            }
        }

        public static void DrawWireMesh(params Vector3[] vertices)
        {
            if (BeginDrawing(GL.LINES))
            {
                var c = Handles.color;

                for (int i = 0; i < vertices.Length - 2; i += 3)
                {
                    var v0 = vertices[i + 0];
                    var v1 = vertices[i + 1];
                    var v2 = vertices[i + 2];

                    UGL.LineTriangle(v0, v1, v2, c);
                }

                EndDrawing();
            }
        }

        private static bool BeginDrawing(int mode)
        {
            if (Event.current.type != EventType.Repaint)
                return false;

            ApplyWireMaterial(Handles.zTest);

            GL.PushMatrix();
            GL.MultMatrix(Handles.matrix);
            GL.Begin(mode);

            return true;
        }

        private static void EndDrawing()
        {
            GL.End();
            GL.PopMatrix();
        }

        private static Action<CompareFunction> CreateApplyWireMaterialMethod()
        {
            return typeof(HandleUtility)
                .GetMethod("ApplyWireMaterial", UBinding.NonPublicStatic)
                .AsAction<CompareFunction>();
        }
    }
}
#endif