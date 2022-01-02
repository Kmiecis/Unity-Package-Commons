using Common.Mathematics;
using System.Collections.Generic;
using UnityEngine;

namespace Common
{
    public class SmoothVertexBuilder : MeshBuilder
    {
        protected float _scale;
        protected Dictionary<Vector3Int, int> _trianglesMap = new Dictionary<Vector3Int, int>();

        public SmoothVertexBuilder(float precision = 0.01f)
        {
            _options = EMeshBuildingOptions.BOUNDS | EMeshBuildingOptions.NORMALS;
            _scale = Mathf.Round(1.0f / precision);
        }

        protected Vector3Int ToKey(Vector3 v)
        {
            return Mathx.RoundToInt(v * _scale);
        }

        protected bool TryAddTriangle(Vector3 v, int t)
        {
            var key = ToKey(v);
            if (_trianglesMap.TryGetValue(key, out int _t))
            {
                AddTriangle(_t);
                return true;
            }
            else
            {
                _trianglesMap[key] = t;
                return false;
            }
        }

        public override void Clear()
        {
            _trianglesMap.Clear();
            base.Clear();
        }

        public override void AddVertex(Vector3 v, int t)
        {
            if (!TryAddTriangle(v, t))
                base.AddVertex(v, t);
        }

        public override void AddVertex(Vector3 v, Color c, int t)
        {
            if (!TryAddTriangle(v, t))
                base.AddVertex(v, c, t);
        }

        public override void AddVertex(Vector3 v, Vector2 uv, int t)
        {
            if (!TryAddTriangle(v, t))
                base.AddVertex(v, uv, t);
        }

        public override void AddVertex(Vector3 v, Vector3 n, int t)
        {
            if (!TryAddTriangle(v, t))
                base.AddVertex(v, n, t);
        }

        public override void AddVertex(Vector3 v, Vector3 n, Color c, int t)
        {
            if (!TryAddTriangle(v, t))
                base.AddVertex(v, n, c, t);
        }

        public override void AddVertex(Vector3 v, Vector3 n, Vector2 uv, int t)
        {
            if (!TryAddTriangle(v, t))
                base.AddVertex(v, n, uv, t);
        }
    }
}
