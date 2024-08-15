using UnityEngine;

namespace Common
{
    public class FlatMeshBuilder : MeshBuilder
    {
        public FlatMeshBuilder() :
            base(EMeshBuildingOptions.RECALCULATE_BOUNDS)
        {
        }

        public static Vector3 GetNormal(Vector3 v0, Vector3 v1, Vector3 v2)
        {
            return Vector3.Cross(v1 - v0, v2 - v1);
        }

        public override void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            int t0, int t1, int t2
        )
        {
            var n = GetNormal(v0, v1, v2);
            base.AddTriangle(
                v0, v1, v2,
                n, n, n,
                t0, t1, t2
            );
        }

        public override void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            Color c0, Color c1, Color c2,
            int t0, int t1, int t2
        )
        {
            var n = GetNormal(v0, v1, v2);
            base.AddTriangle(
                v0, v1, v2,
                n, n, n,
                c0, c1, c2,
                t0, t1, t2
            );
        }

        public override void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            Vector2 uv0, Vector2 uv1, Vector2 uv2,
            int t0, int t1, int t2
        )
        {
            var n = GetNormal(v0, v1, v2);
            base.AddTriangle(
                v0, v1, v2,
                n, n, n,
                uv0, uv1, uv2,
                t0, t1, t2
            );
        }

        public override void AddTriangle(Vector3 v0, Vector3 v1, Vector3 v2)
        {
            var n = GetNormal(v0, v1, v2);
            base.AddTriangle(
                v0, v1, v2,
                n, n, n
            );
        }

        public override void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            Color c0, Color c1, Color c2
        )
        {
            var n = GetNormal(v0, v1, v2);
            base.AddTriangle(
                v0, v1, v2,
                n, n, n,
                c0, c1, c2
            );
        }

        public override void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            Vector2 uv0, Vector2 uv1, Vector2 uv2
        )
        {
            var n = GetNormal(v0, v1, v2);
            base.AddTriangle(
                v0, v1, v2,
                n, n, n,
                uv0, uv1, uv2
            );
        }

        public override void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            int t0, int t1, int t2, int t3
        )
        {
            var n = GetNormal(v0, v1, v2);
            base.AddQuad(
                v0, v1, v2, v3,
                n, n, n, n,
                t0, t1, t2, t3
            );
        }

        public override void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Color c0, Color c1, Color c2, Color c3,
            int t0, int t1, int t2, int t3
        )
        {
            var n = GetNormal(v0, v1, v2);
            base.AddQuad(
                v0, v1, v2, v3,
                n, n, n, n,
                c0, c1, c2, c3,
                t0, t1, t2, t3
            );
        }

        public override void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3,
            int t0, int t1, int t2, int t3
        )
        {
            var n = GetNormal(v0, v1, v2);
            base.AddQuad(
                v0, v1, v2, v3,
                n, n, n, n,
                uv0, uv1, uv2, uv3,
                t0, t1, t2, t3
            );
        }

        public override void AddQuad(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
        {
            var n = GetNormal(v0, v1, v2);
            base.AddQuad(
                v0, v1, v2, v3,
                n, n, n, n
            );
        }

        public override void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Color c0, Color c1, Color c2, Color c3
        )
        {
            var n = GetNormal(v0, v1, v2);
            base.AddQuad(
                v0, v1, v2, v3,
                n, n, n, n,
                c0, c1, c2, c3
            );
        }

        public override void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3
        )
        {
            var n = GetNormal(v0, v1, v2);
            base.AddQuad(
                v0, v1, v2, v3,
                n, n, n, n,
                uv0, uv1, uv2, uv3
            );
        }
    }
}
