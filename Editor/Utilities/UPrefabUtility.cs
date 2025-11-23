using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static class UPrefabUtility
    {
        public static T LoadOrCreatePrefabAtPath<T>(string assetPath, T original)
            where T : Component
        {
            var prefab = LoadOrCreatePrefabAtPath(assetPath, original.gameObject);
            return prefab != null ? prefab.GetComponent<T>() : null;
        }

        public static GameObject LoadOrCreatePrefabAtPath(string assetPath, GameObject original)
        {
            var result = AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);
            if (result == null)
            {
                var instance = Object.Instantiate(original);
                result = PrefabUtility.SaveAsPrefabAsset(instance, assetPath);
                Object.DestroyImmediate(instance);
            }
            return result;
        }
    }
}