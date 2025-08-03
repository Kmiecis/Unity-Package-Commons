using System.IO;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static partial class MeshTools
    {
        [MenuItem("Assets/Commons/Mesh/Toggle Readable")]
        public static void MeshToggleReadable()
        {
            foreach (var mesh in USelection.GetSelected<Mesh>())
            {
                ToggleReadable(mesh);
            }

            AssetDatabase.Refresh();
        }

        public static void ToggleReadable(Mesh mesh)
        {
            const string SearchPhrase = "m_IsReadable: ";
            const string Toggled = "1";
            const string Untoggled = "0";

            var path = AssetDatabase.GetAssetPath(mesh);
            var lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; ++i)
            {
                var line = lines[i];
                if (line.Contains(SearchPhrase))
                {
                    var index = line.IndexOf(SearchPhrase) + SearchPhrase.Length;
                    var current = line.Substring(index, 1);
                    var toggled = current == Toggled ? Untoggled : Toggled;
                    lines[i] = line.Replace(SearchPhrase + current, SearchPhrase + toggled);

                    File.WriteAllLines(path, lines);
                    break;
                }
            }
        }
    }
}