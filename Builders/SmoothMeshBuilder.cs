using Common;
using System.Collections.Generic;
using UnityEngine;

namespace Common
{
	public class SmoothMeshBuilder : IMeshBuilder
	{
		private List<Vector3> m_Vertices = new List<Vector3>();
		private List<int> m_Triangles = new List<int>();
		private List<Vector2> m_UVs = new List<Vector2>();

		private int m_Scale;
		private Dictionary<Vector3Int, int> m_UniqueTriangles = new Dictionary<Vector3Int, int>();

		public SmoothMeshBuilder(float precision = 0.01f)
		{
			m_Scale = Mathf.RoundToInt(1.0f / precision);
		}
		
		public void AddTriangle(
			Vector3 v0, Vector3 v1, Vector3 v2,
			Vector2 uv0, Vector2 uv1, Vector2 uv2
		)
		{
			AddVertex(v0, uv0);
			AddVertex(v1, uv1);
			AddVertex(v2, uv2);
		}

		private void AddVertex(Vector3 v, Vector2 uv)
		{
			var key = Mathx.RoundToInt(v * m_Scale);
			if (m_UniqueTriangles.TryGetValue(key, out int t))
			{
				m_Triangles.Add(t);
			}
			else
			{
				m_Triangles.Add(m_Triangles.Count);
				m_Vertices.Add(v);
				m_UVs.Add(uv);
			}
		}
		
		public void Overwrite(Mesh mesh)
		{
			mesh.Clear();

			mesh.SetVertices(m_Vertices);
			mesh.SetTriangles(m_Triangles, 0);

			if (m_UVs.Count > 0)
				mesh.SetUVs(0, m_UVs);

			mesh.RecalculateNormals();
		}

		public Mesh Build()
		{
			var mesh = new Mesh();
			Overwrite(mesh);
			return mesh;
		}

		public void Clear()
		{
			m_Vertices.Clear();
			m_Triangles.Clear();
			m_UVs.Clear();

			m_UniqueTriangles.Clear();
		}
	}
}