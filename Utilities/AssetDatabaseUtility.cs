using UnityEditor;
using UnityEngine;

namespace Common
{
    public static class AssetDatabaseUtility
    {
		public static void CreateScriptableObjectAsset<T>()
			where T : ScriptableObject
		{
			var filePath = SelectionUtility.GetActiveProjectPath();

			if (!string.IsNullOrEmpty(filePath))
			{
				var asset = ScriptableObject.CreateInstance<T>();

				AssetDatabase.CreateAsset(asset, $"{filePath}/New{typeof(T).Name}.asset");
				AssetDatabase.SaveAssets();

				EditorUtility.FocusProjectWindow();

				Selection.activeObject = asset;
			}
		}

        public static Mesh CreateOrReplaceAssetAtPath(Mesh asset, string path)
        {
            var existingAsset = AssetDatabase.LoadMainAssetAtPath(path) as Mesh;

            if (existingAsset == null)
            {
                AssetDatabase.CreateAsset(asset, path);
                existingAsset = asset;
            }
            else
            {
                existingAsset.Clear();
                EditorUtility.CopySerialized(asset, existingAsset);
            }
            AssetDatabase.SaveAssets();

            return existingAsset;
        }

        public static T CreateOrReplaceAssetAtPath<T>(T asset, string path) where T : Object
        {
            T existingAsset = AssetDatabase.LoadMainAssetAtPath(path) as T;

            if (existingAsset == null)
            {
                AssetDatabase.CreateAsset(asset, path);
                existingAsset = asset;
            }
            else
            {
                EditorUtility.CopySerialized(asset, existingAsset);
            }
            AssetDatabase.SaveAssets();

            return existingAsset;
        }

        public static string GetAssetExtension(EAssetType assetType)
        {
            switch (assetType)
            {
                case EAssetType.Material: return ".mat";
                case EAssetType.Cubemap: return ".cubemap";
                case EAssetType.GUISkin: return ".GUISkin";
                case EAssetType.Animation: return ".anim";
                default: return ".asset";
            }
        }

		public static string GetAssetExtension(Material material)
		{
			return GetAssetExtension(EAssetType.Material);
		}

		public static string GetAssetExtension(Cubemap cubemap)
		{
			return GetAssetExtension(EAssetType.Cubemap);
		}

		public static string GetAssetExtension(GUISkin GUISkin)
		{
			return GetAssetExtension(EAssetType.GUISkin);
		}

		public static string GetAssetExtension(Animation animation)
		{
			return GetAssetExtension(EAssetType.Animation);
		}

		public static string GetAssetExtension(Object obj)
		{
			return GetAssetExtension(EAssetType.Other);
		}

        public static string ConstructPathToAsset(string path, string name, EAssetType type)
        {
            return string.Format(GENERAL_PATH_FORMAT, path, name, GetAssetExtension(type));
        }

        private const string GENERAL_PATH_FORMAT = "Assets/{0}/{1}{2}";

        public enum EAssetType
        {
            Material,
            Cubemap,
            GUISkin,
            Animation,
            Other
        }
    }
}