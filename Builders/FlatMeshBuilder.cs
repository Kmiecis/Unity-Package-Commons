using System.Collections.Generic;
using UnityEngine;

namespace Common
{
	public class FlatMeshBuilder : IMeshBuilder
	{
		private List<Vector3> m_Vertices = new List<Vector3>();
		private List<int> m_Triangles = new List<int>();
		private List<Vector2> m_UVs = new List<Vector2>();

		private List<Vector3> m_Normals = new List<Vector3>();

		public void AddTriangle(Vector3 v0, Vector3 v1, Vector3 v2)
		{
			var n = Vector3.Cross(v1 - v0, v2 - v1);

			m_Vertices.Add(v0);
			m_Vertices.Add(v1);
			m_Vertices.Add(v2);

			for (int i = 0; i < 3; i++)
			{
				m_Triangles.Add(m_Triangles.Count);
				m_Normals.Add(n);
			}
		}
		
		public void AddUVs(Vector2 uv0, Vector2 uv1, Vector2 uv2)
		{
			m_UVs.Add(uv0);
			m_UVs.Add(uv1);
			m_UVs.Add(uv2);
		}

		public void Overwrite(Mesh mesh)
		{
			mesh.Clear();

			mesh.SetVertices(m_Vertices);
			mesh.SetTriangles(m_Triangles, 0);

			if (m_UVs.Count > 0)
				mesh.SetUVs(0, m_UVs);

			mesh.SetNormals(m_Normals);
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

			m_Normals.Clear();
		}
	}
}