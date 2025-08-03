using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static partial class MeshTools
    {
        [MenuItem("Assets/Commons/Mesh/Recalculate Bounds")]
        public static void MenuRecalculateBounds()
        {
            foreach (var mesh in USelection.GetSelected<Mesh>())
            {
                mesh.RecalculateBounds();
            }

            AssetDatabase.Refresh();
        }

        [MenuItem("Assets/Commons/Mesh/Recalculate Normals")]
        public static void MeshRecalculateNormals()
        {
            foreach (var mesh in USelection.GetSelected<Mesh>())
            {
                mesh.RecalculateNormals();
            }

            AssetDatabase.Refresh();
        }
    }
}