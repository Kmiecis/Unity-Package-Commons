using System.IO;
using UnityEditor;
using UnityEngine;

namespace CommonEditor.Extensions
{
    public static class ScriptableObjectExtensions
    {
        public static ScriptableObject SaveAsset(this ScriptableObject self, string path = null, string name = null)
        {
            var filepath = path ?? "Assets";
            var filename = name ?? string.Concat("New", self.GetType().Name);

            var fullpath = Path.GetFullPath(filepath);
            if (!Directory.Exists(fullpath))
            {
                Directory.CreateDirectory(fullpath);
            }

            var assetpath = AssetDatabase.GenerateUniqueAssetPath(filepath + "/" + filename + ".asset");

            AssetDatabase.CreateAsset(self, assetpath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            EditorGUIUtility.PingObject(self);

            return self;
        }
    }
}
