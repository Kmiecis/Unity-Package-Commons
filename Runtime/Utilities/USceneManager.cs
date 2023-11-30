using UnityEngine.SceneManagement;

namespace Common
{
    public static class USceneManager
    {
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

        public static bool HasScene(string name)
        {
            return SceneManager.GetSceneByName(name).IsValid();
        }

        public static bool HasScene(int buildIndex)
        {
            return SceneManager.GetSceneByBuildIndex(buildIndex).IsValid();
        }
    }
}