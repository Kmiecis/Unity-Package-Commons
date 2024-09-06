using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class UGL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Line(Vector3 v0, Vector3 v1)
        {
            GL.Vertex(v0);
            GL.Vertex(v1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Line(Vector3 v0, Vector3 v1, Color c)
        {
            GL.Color(c);

            GL.Vertex(v0);
            GL.Vertex(v1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Line(Vector3 v0, Vector3 v1, Color c0, Color c1)
        {
            GL.Color(c0);
            GL.Vertex(v0);

            GL.Color(c1);
            GL.Vertex(v1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void LineTriangle(Vector3 v0, Vector3 v1, Vector3 v2)
        {
            Line(v0, v1);
            Line(v1, v2);
            Line(v2, v0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void LineTriangle(Vector3 v0, Vector3 v1, Vector3 v2, Color c)
        {
            GL.Color(c);

            Line(v0, v1);
            Line(v1, v2);
            Line(v2, v0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void LineTriangle(Vector3 v0, Vector3 v1, Vector3 v2, Color c0, Color c1, Color c2)
        {
            Line(v0, v1, c0, c1);
            Line(v1, v2, c1, c2);
            Line(v2, v0, c2, c0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Triangle(Vector3 v0, Vector3 v1, Vector3 v2)
        {
            GL.Vertex(v0);
            GL.Vertex(v1);
            GL.Vertex(v2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Triangle(Vector3 v0, Vector3 v1, Vector3 v2, Color c)
        {
            GL.Color(c);

            GL.Vertex(v0);
            GL.Vertex(v1);
            GL.Vertex(v2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Triangle(Vector3 v0, Vector3 v1, Vector3 v2, Color c0, Color c1, Color c2)
        {
            GL.Color(c0);
            GL.Vertex(v0);

            GL.Color(c1);
            GL.Vertex(v1);

            GL.Color(c2);
            GL.Vertex(v2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Quad(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
        {
            GL.Vertex(v0);
            GL.Vertex(v1);
            GL.Vertex(v2);
            GL.Vertex(v3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Quad(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, Color c)
        {
            GL.Color(c);

            GL.Vertex(v0);
            GL.Vertex(v1);
            GL.Vertex(v2);
            GL.Vertex(v3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Quad(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, Color c0, Color c1, Color c2, Color c3)
        {
            GL.Color(c0);
            GL.Vertex(v0);

            GL.Color(c1);
            GL.Vertex(v1);

            GL.Color(c2);
            GL.Vertex(v2);

            GL.Color(c3);
            GL.Vertex(v3);
        }
    }
}