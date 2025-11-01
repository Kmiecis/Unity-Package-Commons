using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static class SearchMissings
    {
        [MenuItem("Assets/Commons/Search Missings")]
        private static void Search()
        {
            var selections = GetSelections();

            if (selections.Length == 0)
            {
                ShowNotFoundPopup();
            }
            else
            {
                Selection.objects = selections;
                foreach (var selection in selections)
                {
                    EditorGUIUtility.PingObject(selection);
                }
            }
        }

        private static Object[] GetSelections()
        {
            var result = new List<GameObject>();

            var gameObjects = UAssetDatabase.LoadAssets<GameObject>();

            var divisor = 1.0f / gameObjects.Length;

            for (int i = 0; i < gameObjects.Length; ++i)
            {
                UpdateProgressBar(i * divisor);

                var gameObject = gameObjects[i];

                if (HasMissingComponent(gameObject))
                {
                    result.Add(gameObject);
                }
            }

            HideProgressBar();

            return result.ToArray();
        }

        private static bool HasMissingComponent(GameObject gameObject)
        {
            var components = gameObject.GetComponents<Component>();
            for (int i = 0; i < components.Length; ++i)
            {
                if (components[i] == null)
                {
                    return true;
                }
            }
            foreach (Transform child in gameObject.transform)
            {
                if (HasMissingComponent(child.gameObject))
                {
                    return true;
                }
            }
            return false;
        }

        private static void UpdateProgressBar(float progress)
        {
            const string PROGRESS_TITLE = "Missings searcher";
            const string PROGRESS_INFO = "Searching...";

            EditorUtility.DisplayProgressBar(PROGRESS_TITLE, PROGRESS_INFO, progress);
        }

        private static void HideProgressBar()
        {
            EditorUtility.ClearProgressBar();
        }

        private static void ShowNotFoundPopup()
        {
            const string DIALOG_TITLE = "Missings searcher";
            const string DIALOG_OK = "Ok";

            var dialogMessage = $"No missings found";

            EditorUtility.DisplayDialog(DIALOG_TITLE, dialogMessage, DIALOG_OK);
        }
    }
}