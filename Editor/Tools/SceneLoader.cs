using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CommonEditor
{
    public static partial class SceneTools
    {
        [MenuItem("Assets/Commons/Scene/Load")]
        public static void SceneLoad()
        {
            var selection = Selection.activeObject;
            if (selection == null)
            {
                Debug.LogError("No object selected to be loaded");
                return;
            }

            var assetPath = AssetDatabase.GetAssetPath(selection);
            var assetExtension = Path.GetExtension(assetPath);
            if (assetExtension != ".unity")
            {
                Debug.LogError("No scene selected to be loaded");
                return;
            }

            LoadSceneFrom(assetPath);
        }

        [MenuItem("Assets/Commons/Scene/Unload")]
        public static void SceneUnload()
        {
            var selection = Selection.activeObject;
            if (selection == null)
            {
                Debug.LogError("No object selected to be unloaded");
                return;
            }

            var assetPath = AssetDatabase.GetAssetPath(selection);
            var assetExtension = Path.GetExtension(assetPath);
            if (assetExtension != ".unity")
            {
                Debug.LogError("No scene selected to be unloaded");
                return;
            }

            UnloadSceneFrom(assetPath);
        }

        private static void LoadSceneFrom(string scenePath)
        {
            if (Application.isPlaying)
            {
                var parameters = new LoadSceneParameters
                {
                    loadSceneMode = LoadSceneMode.Additive,
                    localPhysicsMode = LocalPhysicsMode.None
                };
                EditorSceneManager.LoadSceneAsyncInPlayMode(scenePath, parameters);
            }
            else
            {
                var mode = OpenSceneMode.Additive;

                EditorSceneManager.OpenScene(scenePath, mode);
            }
        }

        private static void UnloadSceneFrom(string scenePath)
        {
            if (Application.isPlaying)
            {
                EditorSceneManager.UnloadSceneAsync(scenePath, UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
            }
            else
            {
                var scene = SceneManager.GetSceneByPath(scenePath);

                EditorSceneManager.CloseScene(scene, true);
            }
        }
    }
}