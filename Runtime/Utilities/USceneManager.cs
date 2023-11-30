using UnityEngine.SceneManagement;

namespace Common
{
    public static class USceneManager
    {
        public static bool TryGetSceneByPath(string scenePath, out Scene scene)
        {
            scene = SceneManager.GetSceneByPath(scenePath);
            return scene.IsValid();
        }

        public static bool TryGetSceneByName(string name, out Scene scene)
        {
            scene = SceneManager.GetSceneByName(name);
            return scene.IsValid();
        }

        public static bool TryGetSceneByBuildIndex(int buildIndex, out Scene scene)
        {
            scene = SceneManager.GetSceneByBuildIndex(buildIndex);
            return scene.IsValid();
        }

        public static bool IsSceneLoadedByPath(string scenePath)
        {
            return SceneManager.GetSceneByPath(scenePath).IsValid();
        }

        public static bool IsSceneLoadedByName(string name)
        {
            return SceneManager.GetSceneByName(name).IsValid();
        }

        public static bool IsSceneLoadedByBuildIndex(int buildIndex)
        {
            return SceneManager.GetSceneByBuildIndex(buildIndex).IsValid();
        }
    }
}