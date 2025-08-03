using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static partial class MeshTools
    {
        [MenuItem("Assets/Commons/Mesh/Merge SubMeshes")]
        public static void MeshMergeSubMeshes()
        {
            foreach (var mesh in USelection.GetSelected<Mesh>())
            {
                MergeSubmeshes(mesh);

                AssetDatabase.SaveAssetIfDirty(mesh);
            }

            AssetDatabase.Refresh();
        }

        public static void MergeSubmeshes(Mesh mesh)
        {
            var triangles = new List<int>();
            for (int i = 0; i < mesh.subMeshCount; ++i)
            {
                var tris = mesh.GetTriangles(i);
                triangles.AddRange(tris);
            }

            mesh.subMeshCount = 1;
            mesh.SetTriangles(triangles, 0);
        }
    }
}