using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static class UAssetDatabase
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

        public static T CreateOrReplaceAssetAtPath<T>(T asset, string path)
            where T : Object
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
                {
                    mesh.Clear();
                }
                EditorUtility.CopySerialized(asset, existingAsset);
            }
            AssetDatabase.SaveAssets();

            return existingAsset;
        }

        public static bool DeleteAsset(Object assetObject)
        {
            var path = AssetDatabase.GetAssetPath(assetObject);
            return AssetDatabase.DeleteAsset(path);
        }

        public static bool DeleteAssets(Object[] assetObjects, List<string> outFailedPaths)
        {
            var paths = assetObjects.Select(o => AssetDatabase.GetAssetPath(o)).ToArray();
            return AssetDatabase.DeleteAssets(paths, outFailedPaths);
        }

        public static T[] LoadAssets<T>(params string[] folders)
            where T : Object
        {
            var guids = AssetDatabase.FindAssets("t:" + typeof(T).Name, folders);

            var result = new T[guids.Length];
            for (int i = 0; i < guids.Length; ++i)
            {
                var path = AssetDatabase.GUIDToAssetPath(guids[i]);
                result[i] = AssetDatabase.LoadAssetAtPath<T>(path);
            }
            return result;
        }

        public static T LoadAnyAsset<T>(params string[] folders)
            where T : Object
        {
            var assets = LoadAssets<T>(folders);
            return assets.Length > 0 ? assets[0] : null;
        }

        public static string GetAssetDirectory(Object asset)
        {
            var path = AssetDatabase.GetAssetPath(asset);

            if (!string.IsNullOrEmpty(path))
            {
                if (Directory.Exists(path))
                {
                    return path;
                }
                return Path.GetDirectoryName(path);
            }
            return null;
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

        public static EAssetType GetAssetType(Object value)
        {
            if (value is Animation) return EAssetType.Animation;
            if (value is Cubemap) return EAssetType.Cubemap;
            if (value is GUISkin) return EAssetType.GUISkin;
            if (value is Material) return EAssetType.Material;
            return EAssetType.Other;
        }

        public static string ConstructPathToAsset(string path, string name, EAssetType type)
        {
            return string.Format(GENERAL_PATH_FORMAT, path, name, GetAssetExtension(type));
        }
    }
}
