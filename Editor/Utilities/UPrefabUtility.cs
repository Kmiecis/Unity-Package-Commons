using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static class UPrefabUtility
    {
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