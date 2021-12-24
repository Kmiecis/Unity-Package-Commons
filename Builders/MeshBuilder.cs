using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Common
{
    public class MeshBuilder : IDisposable
    {
        protected EMeshBuildingOptions _options = EMeshBuildingOptions.NONE;
        protected List<int> _triangles = new List<int>();
        protected List<Vector3> _vertices = new List<Vector3>();
        protected List<Vector3> _normals = new List<Vector3>();
        protected List<Color> _colors = new List<Color>();
        protected List<Vector2> _uvs = new List<Vector2>();
        
        public EMeshBuildingOptions Options
        {
            get => _options;
            set => _options = value;
        }

        public List<int> Triangles
        {
            get => _triangles;
            set => _triangles = value;
        }

        public List<Vector3> Vertices
        {
            get => _vertices;
            set => _vertices = value;
        }

        public List<Vector3> Normals
        {
            get => _normals;
            set => _normals = value;
        }
        
        public List<Color> Colors
        {
            get => _colors;
            set => _colors = value;
        }

        public List<Vector2> UVs
        {
            get => _uvs;
            set => _uvs = value;
        }
        
        public virtual void Overwrite(Mesh mesh)
        {
            mesh.Clear();

            mesh.indexFormat = _vertices.Count > ushort.MaxValue ? IndexFormat.UInt32 : IndexFormat.UInt16;

            mesh.SetVertices(_vertices);
            mesh.SetTriangles(_triangles, 0);

            if (_normals.Count > 0)
                mesh.SetNormals(_normals);
            if (_colors.Count > 0)
                mesh.SetColors(_colors);
            if (_uvs.Count > 0)
                mesh.SetUVs(0, _uvs);

            if (BitUtility.HasFlag((int)_options, (int)EMeshBuildingOptions.BOUNDS))
                mesh.RecalculateBounds();
            if (BitUtility.HasFlag((int)_options, (int)EMeshBuildingOptions.NORMALS))
                mesh.RecalculateNormals();
            if (BitUtility.HasFlag((int)_options, (int)EMeshBuildingOptions.TANGENTS))
                mesh.RecalculateTangents();
        }

        public Mesh Build()
        {
            var mesh = new Mesh();
            Overwrite(mesh);
            return mesh;
        }

        public virtual void Clear()
        {
            _triangles.Clear();
            _vertices.Clear();
            _normals.Clear();
            _colors.Clear();
            _uvs.Clear();
        }

        public void Dispose()
        {
            Clear();
        }

        public virtual void AddTriangle(int t)
        {
            _triangles.Add(t);
        }

        public virtual void AddVertex(Vector3 v, int t)
        {
            AddTriangle(t);
            _vertices.Add(v);
        }

        public virtual void AddVertex(Vector3 v, Color c, int t)
        {
            AddVertex(v, t);
            _colors.Add(c);
        }

        public virtual void AddVertex(Vector3 v, Vector2 uv, int t)
        {
            AddVertex(v, t);
            _uvs.Add(uv);
        }

        public virtual void AddVertex(Vector3 v, Vector3 n, int t)
        {
            AddVertex(v, t);
            _normals.Add(n);
        }

        public virtual void AddVertex(Vector3 v, Vector3 n, Color c, int t)
        {
            AddVertex(v, n, t);
            _colors.Add(c);
        }

        public virtual void AddVertex(Vector3 v, Vector3 n, Vector2 uv, int t)
        {
            AddVertex(v, n, t);
            _uvs.Add(uv);
        }

        public virtual void AddVertex(Vector3 v)
        {
            AddVertex(v, _vertices.Count);
        }

        public virtual void AddVertex(Vector3 v, Color c)
        {
            AddVertex(v, c, _vertices.Count);
        }

        public virtual void AddVertex(Vector3 v, Vector2 uv)
        {
            AddVertex(v, uv, _vertices.Count);
        }

        public virtual void AddVertex(Vector3 v, Vector3 n)
        {
            AddVertex(v, n, _vertices.Count);
        }

        public virtual void AddVertex(Vector3 v, Vector3 n, Color c)
        {
            AddVertex(v, n, c, _vertices.Count);
        }

        public virtual void AddVertex(Vector3 v, Vector3 n, Vector2 uv)
        {
            AddVertex(v, n, uv, _vertices.Count);
        }

        public virtual void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            int t0, int t1, int t2
        )
        {
            AddVertex(v0, t0);
            AddVertex(v1, t1);
            AddVertex(v2, t2);
        }

        public virtual void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            Color c0, Color c1, Color c2,
            int t0, int t1, int t2
        )
        {
            AddVertex(v0, c0, t0);
            AddVertex(v1, c1, t1);
            AddVertex(v2, c2, t2);
        }

        public virtual void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            Vector2 uv0, Vector2 uv1, Vector2 uv2,
            int t0, int t1, int t2
        )
        {
            AddVertex(v0, uv0, t0);
            AddVertex(v1, uv1, t1);
            AddVertex(v2, uv2, t2);
        }

        public virtual void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            Vector3 n0, Vector3 n1, Vector3 n2,
            int t0, int t1, int t2
        )
        {
            AddVertex(v0, n0, t0);
            AddVertex(v1, n1, t1);
            AddVertex(v2, n2, t2);
        }

        public virtual void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            Vector3 n0, Vector3 n1, Vector3 n2,
            Color c0, Color c1, Color c2,
            int t0, int t1, int t2
        )
        {
            AddVertex(v0, n0, c0, t0);
            AddVertex(v1, n1, c1, t1);
            AddVertex(v2, n2, c2, t2);
        }

        public virtual void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            Vector3 n0, Vector3 n1, Vector3 n2,
            Vector2 uv0, Vector2 uv1, Vector2 uv2,
            int t0, int t1, int t2
        )
        {
            AddVertex(v0, n0, uv0, t0);
            AddVertex(v1, n1, uv1, t1);
            AddVertex(v2, n2, uv2, t2);
        }

        public virtual void AddTriangle(Vector3 v0, Vector3 v1, Vector3 v2)
        {
            AddVertex(v0);
            AddVertex(v1);
            AddVertex(v2);
        }

        public virtual void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            Color c0, Color c1, Color c2
        )
        {
            AddVertex(v0, c0);
            AddVertex(v1, c1);
            AddVertex(v2, c2);
        }

        public virtual void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            Vector2 uv0, Vector2 uv1, Vector2 uv2
        )
        {
            AddVertex(v0, uv0);
            AddVertex(v1, uv1);
            AddVertex(v2, uv2);
        }

        public virtual void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            Vector3 n0, Vector3 n1, Vector3 n2
        )
        {
            AddVertex(v0, n0);
            AddVertex(v1, n1);
            AddVertex(v2, n2);
        }

        public virtual void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            Vector3 n0, Vector3 n1, Vector3 n2,
            Color c0, Color c1, Color c2
        )
        {
            AddVertex(v0, n0, c0);
            AddVertex(v1, n1, c1);
            AddVertex(v2, n2, c2);
        }

        public virtual void AddTriangle(
            Vector3 v0, Vector3 v1, Vector3 v2,
            Vector3 n0, Vector3 n1, Vector3 n2,
            Vector2 uv0, Vector2 uv1, Vector2 uv2
        )
        {
            AddVertex(v0, n0, uv0);
            AddVertex(v1, n1, uv1);
            AddVertex(v2, n2, uv2);
        }

        public virtual void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            int t0, int t1, int t2, int t3
        )
        {
            AddTriangle(
                v0, v1, v2,
                t0, t1, t2
            );
            AddTriangle(
                v0, v2, v3,
                t0, t2, t3
            );
        }

        public virtual void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Color c0, Color c1, Color c2, Color c3,
            int t0, int t1, int t2, int t3
        )
        {
            AddTriangle(
                v0, v1, v2,
                c0, c1, c2,
                t0, t1, t2
            );
            AddTriangle(
                v0, v2, v3,
                c0, c2, c3,
                t0, t2, t3
            );
        }

        public virtual void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3,
            int t0, int t1, int t2, int t3
        )
        {
            AddTriangle(
                v0, v1, v2,
                uv0, uv1, uv2,
                t0, t1, t2
            );
            AddTriangle(
                v0, v2, v3,
                uv0, uv2, uv3,
                t0, t2, t3
            );
        }

        public virtual void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Vector3 n0, Vector3 n1, Vector3 n2, Vector3 n3,
            int t0, int t1, int t2, int t3
        )
        {
            AddTriangle(
                v0, v1, v2,
                n0, n1, n2,
                t0, t1, t2
            );
            AddTriangle(
                v0, v2, v3,
                n0, n2, n3,
                t0, t2, t3
            );
        }

        public virtual void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Vector3 n0, Vector3 n1, Vector3 n2, Vector3 n3,
            Color c0, Color c1, Color c2, Color c3,
            int t0, int t1, int t2, int t3
        )
        {
            AddTriangle(
                v0, v1, v2,
                n0, n1, n2,
                c0, c1, c2,
                t0, t1, t2
            );
            AddTriangle(
                v0, v2, v3,
                n0, n2, n3,
                c0, c2, c3,
                t0, t2, t3
            );
        }

        public virtual void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Vector3 n0, Vector3 n1, Vector3 n2, Vector3 n3,
            Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3,
            int t0, int t1, int t2, int t3
        )
        {
            AddTriangle(
                v0, v1, v2,
                n0, n1, n2,
                uv0, uv1, uv2,
                t0, t1, t2
            );
            AddTriangle(
                v0, v2, v3,
                n0, n2, n3,
                uv0, uv2, uv3,
                t0, t2, t3
            );
        }

        public virtual void AddQuad(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
        {
            var t0 = _vertices.Count;
            AddQuad(
                v0, v1, v2, v3,
                t0, t0 + 1, t0 + 2, t0 + 3
            );
        }

        public virtual void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Color c0, Color c1, Color c2, Color c3
        )
        {
            var t0 = _vertices.Count;
            AddQuad(
                v0, v1, v2, v3,
                c0, c1, c2, c3,
                t0, t0 + 1, t0 + 2, t0 + 3
            );
        }

        public virtual void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3
        )
        {
            var t0 = _vertices.Count;
            AddQuad(
                v0, v1, v2, v3,
                uv0, uv1, uv2, uv3,
                t0, t0 + 1, t0 + 2, t0 + 3
            );
        }

        public virtual void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Vector3 n0, Vector3 n1, Vector3 n2, Vector3 n3
        )
        {
            var t0 = _vertices.Count;
            AddQuad(
                v0, v1, v2, v3,
                n0, n1, n2, n3,
                t0, t0 + 1, t0 + 2, t0 + 3
            );
        }

        public virtual void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Vector3 n0, Vector3 n1, Vector3 n2, Vector3 n3,
            Color c0, Color c1, Color c2, Color c3
        )
        {
            var t0 = _vertices.Count;
            AddQuad(
                v0, v1, v2, v3,
                n0, n1, n2, n3,
                c0, c1, c2, c3,
                t0, t0 + 1, t0 + 2, t0 + 3
            );
        }

        public virtual void AddQuad(
            Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3,
            Vector3 n0, Vector3 n1, Vector3 n2, Vector3 n3,
            Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3
        )
        {
            var t0 = _vertices.Count;
            AddQuad(
                v0, v1, v2, v3,
                n0, n1, n2, n3,
                uv0, uv1, uv2, uv3,
                t0, t0 + 1, t0 + 2, t0 + 3
            );
        }
    }
}
