using System;
using UnityEngine;

namespace Common
{
    public static class UGizmos
    {
        public static void DrawVector(Vector3 center, Vector3 direction)
        {
            Gizmos.DrawLine(center, center + direction);
        }

        public static void DrawWireRect(Vector2 center, Vector2 size)
        {
            Gizmos.DrawWireCube(center, size);
        }

        public static void DrawRect(Vector2 center, Vector2 size)
        {
            Gizmos.DrawCube(center, size);
        }

        public static void DrawCubes(Vector3[] centers, Vector3[] sizes)
        {
            var length = Math.Min(centers.Length, sizes.Length);
            for (int i = 0; i < length; ++i)
            {
                Gizmos.DrawCube(centers[i], sizes[i]);
            }
        }

        public static void DrawCubes(Vector3[] centers, Vector3 size)
        {
            for (int i = 0; i < centers.Length; ++i)
            {
                Gizmos.DrawCube(centers[i], size);
            }
        }

        public static void DrawWireCubes(Vector3[] centers, Vector3[] sizes)
        {
            var length = Math.Min(centers.Length, sizes.Length);
            for (int i = 0; i < length; ++i)
            {
                Gizmos.DrawWireCube(centers[i], sizes[i]);
            }
        }

        public static void DrawWireCubes(Vector3[] centers, Vector3 size)
        {
            for (int i = 0; i < centers.Length; ++i)
            {
                Gizmos.DrawWireCube(centers[i], size);
            }
        }

        public static void DrawSpheres(Vector3[] centers, float[] radiuses)
        {
            var length = Math.Min(centers.Length, radiuses.Length);
            for (int i = 0; i < length; ++i)
            {
                Gizmos.DrawSphere(centers[i], radiuses[i]);
            }
        }

        public static void DrawSpheres(Vector3[] centers, float radius)
        {
            for (int i = 0; i < centers.Length; ++i)
            {
                Gizmos.DrawSphere(centers[i], radius);
            }
        }

        public static void DrawWireSpheres(Vector3[] centers, float[] radiuses)
        {
            var length = Math.Min(centers.Length, radiuses.Length);
            for (int i = 0; i < length; ++i)
            {
                Gizmos.DrawWireSphere(centers[i], radiuses[i]);
            }
        }

        public static void DrawWireSpheres(Vector3[] centers, float radius)
        {
            for (int i = 0; i < centers.Length; ++i)
            {
                Gizmos.DrawWireSphere(centers[i], radius);
            }
        }

        public static void DrawLines(Vector3[] froms, Vector3[] tos)
        {
            var length = Math.Min(froms.Length, tos.Length);
            for (int i = 0; i < length; ++i)
            {
                Gizmos.DrawLine(froms[i], tos[i]);
            }
        }

        public static void DrawLines(Vector3[] points)
        {
            for (int i = 1; i < points.Length; ++i)
            {
                Gizmos.DrawLine(points[i - 1], points[i]);
            }
        }

        public static void DrawVectors(Vector3[] centers, Vector3[] directions)
        {
            var length = Math.Min(centers.Length, directions.Length);
            for (int i = 0; i < length; ++i)
            {
                DrawVector(centers[i], directions[i]);
            }
        }
    }
}
