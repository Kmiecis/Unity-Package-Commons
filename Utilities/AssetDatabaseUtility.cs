#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace Common
{
    public static class AssetDatabaseUtility
    {
        private const string GENERAL_PATH_FORMAT = "Assets/{0}/{1}.{2}";

        public enum EAssetType
        {
            Material,
            Cubemap,
            GUISkin,
            Animation,
            Other
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
                if (asset is Mesh mesh)
                    mesh.Clear();
                EditorUtility.CopySerialized(asset, existingAsset);
            }
            AssetDatabase.SaveAssets();

            return existingAsset;
        }

        public static string GetAssetExtension(EAssetType assetType)
        {
            switch (assetType)
            {
                case EAssetType.Material: return "mat";
                case EAssetType.Cubemap: return "cubemap";
                case EAssetType.GUISkin: return "GUISkin";
                case EAssetType.Animation: return "anim";
                default: return "asset";
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

        public static T[] LoadAssets<T>()
            where T : Object
        {
            var guids = AssetDatabase.FindAssets("t:" + typeof(T).Name);

            var result = new T[guids.Length];
            for (int i = 0; i < guids.Length; ++i)
            {
                var path = AssetDatabase.GUIDToAssetPath(guids[i]);
                result[i] = AssetDatabase.LoadAssetAtPath<T>(path);
            }
            return result;
        }
    }
}
#endif