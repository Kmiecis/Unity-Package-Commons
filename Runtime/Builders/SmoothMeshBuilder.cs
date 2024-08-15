using Common.Mathematics;
using System.Collections.Generic;
using UnityEngine;

namespace Common
{
    public class SmoothMeshBuilder : MeshBuilder
    {
        protected float _scale;
        protected Dictionary<Vector3Int, int> _trianglesMap = new Dictionary<Vector3Int, int>();

        public SmoothMeshBuilder(float precision = 0.01f)
        {
            _options = EMeshBuildingOptions.RECALCULATE_BOUNDS | EMeshBuildingOptions.RECALCULATE_NORMALS;
            _scale = Mathf.Round(1.0f / precision);
        }

        protected Vector3Int ToKey(Vector3 v)
        {
            return Mathx.RoundToInt(v * _scale);
        }

        protected bool TryAddTriangle(Vector3 v)
        {
            var key = ToKey(v);
            if (_trianglesMap.TryGetValue(key, out int _t))
            {
                AddTriangle(_t);
                return true;
            }
            else
            {
                _trianglesMap[key] = _vertices.Count;
                return false;
            }
        }

        public override void Clear()
        {
            _trianglesMap.Clear();
            base.Clear();
        }

        public override void AddVertex(Vector3 v)
        {
            if (!TryAddTriangle(v))
                base.AddVertex(v);
        }

        public override void AddVertex(Vector3 v, Color c)
        {
            if (!TryAddTriangle(v))
                base.AddVertex(v, c);
        }

        public override void AddVertex(Vector3 v, Vector2 uv)
        {
            if (!TryAddTriangle(v))
                base.AddVertex(v, uv);
        }

        public override void AddVertex(Vector3 v, Vector3 n)
        {
            if (!TryAddTriangle(v))
                base.AddVertex(v, n);
        }

        public override void AddVertex(Vector3 v, Vector3 n, Color c)
        {
            if (!TryAddTriangle(v))
                base.AddVertex(v, n, c);
        }

        public override void AddVertex(Vector3 v, Vector3 n, Vector2 uv)
        {
            if (!TryAddTriangle(v))
                base.AddVertex(v, n, uv);
        }

        public override void AddQuad(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
        {
            AddTriangle(v0, v1, v2);
            AddTriangle(v0, v2, v3);
        }

        public override void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Color c0, Color c1, Color c2, Color c3
        )
        {
            AddTriangle(
                v0, v1, v2,
                c0, c1, c2
            );
            AddTriangle(
                v0, v2, v3,
                c0, c2, c3
            );
        }

        public override void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3
        )
        {
            AddTriangle(
                v0, v1, v2,
                uv0, uv1, uv2
            );
            AddTriangle(
                v0, v2, v3,
                uv0, uv2, uv3
            );
        }

        public override void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Vector3 n0, Vector3 n1, Vector3 n2, Vector3 n3
        )
        {
            AddTriangle(
                v0, v1, v2,
                n0, n1, n2
            );
            AddTriangle(
                v0, v2, v3,
                n0, n2, n3
            );
        }

        public override void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Vector3 n0, Vector3 n1, Vector3 n2, Vector3 n3,
            Color c0, Color c1, Color c2, Color c3
        )
        {
            AddTriangle(
                v0, v1, v2,
                n0, n1, n2,
                c0, c1, c2
            );
            AddTriangle(
                v0, v2, v3,
                n0, n2, n3,
                c0, c2, c3
            );
        }

        public override void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Vector3 n0, Vector3 n1, Vector3 n2, Vector3 n3,
            Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3
        )
        {
            AddTriangle(
                v0, v1, v2,
                n0, n1, n2,
                uv0, uv1, uv2
            );
            AddTriangle(
                v0, v2, v3,
                n0, n2, n3,
                uv0, uv2, uv3
            );
        }
    }
}
