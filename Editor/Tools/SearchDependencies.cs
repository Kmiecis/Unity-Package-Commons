using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static class SearchDependencies
    {
        [MenuItem("Assets/Commons/Search Dependencies")]
        private static void Search()
        {
            var selection = Selection.activeObject;
            if (selection == null)
            {
                Debug.LogError("No object selected to search dependencies for");
                return;
            }

            var assetPath = AssetDatabase.GetAssetPath(selection);
            var assetExtension = Path.GetExtension(assetPath);

            var searchExtensions = SearchExtensionByExtension(assetExtension);
            if (searchExtensions == null)
            {
                Debug.LogError($"No search extension found for given selection extension '{assetExtension}'");
                return;
            }

            var searchFiles = GetFiles(searchExtensions);
            if (searchFiles.Length == 0)
            {
                ShowNotFoundPopup(searchExtensions);
                return;
            }

            var assetGuid = AssetDatabase.GUIDFromAssetPath(assetPath);
            var selections = GetSelections(searchFiles, assetGuid.ToString());
            if (selections.Length == 0)
            {
                ShowNotFoundPopup(searchExtensions);
                return;
            }

            Selection.objects = selections;
            foreach (var select in selections)
            {
                EditorGUIUtility.PingObject(select);
            }
        }

        private static string[] GetFiles(string[] extensions)
        {
            var result = new List<string>();

            foreach (var extension in extensions)
            {
                var files = Directory.GetFiles("Assets", $"*{extension}", SearchOption.AllDirectories);
                result.AddRange(files);
            }

            return result.ToArray();
        }

        private static Object[] GetSelections(string[] files, string search)
        {
            var result = new List<Object>();

            var divisor = 1.0f / files.Length;
            for (int i = 0; i < files.Length; ++i)
            {
                UpdateProgressBar(i * divisor);

                var file = files[i];
                var found = GetSelection(file, search);
                if (found != null)
                {
                    result.Add(found);
                }
            }

            HideProgressBar();

            return result.ToArray();
        }

        private static Object GetSelection(string file, string search)
        {
            using (var reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(search))
                    {
                        return AssetDatabase.LoadAssetAtPath<Object>(file);
                    }
                }
            }

            return null;
        }

        private static string[] SearchExtensionByExtension(string extension)
        {
            const string SHADER = ".shader";
            const string SHADERGRAPH = ".shadergraph";
            const string SHADERSUBGRAPH = ".shadersubgraph";
            const string MATERIAL = ".mat";
            const string ASSET = ".asset";
            const string PREFAB = ".prefab";
            const string SCENE = ".unity";
            const string ANIMATION = ".anim";
            const string ANIMATOR = ".controller";
            const string MESH = ".mesh";
            const string SPRITEATLAS = ".spriteatlas";
            const string JPG = ".jpg";
            const string PNG = ".png";
            const string SCRIPT = ".cs";

            switch (extension)
            {
                case SHADER:
                case SHADERGRAPH:
                    return new string[] { MATERIAL };
                case MATERIAL:
                    return new string[] { ASSET, PREFAB };
                case PNG:
                case JPG:
                    return new string[] { ASSET, MATERIAL, PREFAB, SPRITEATLAS };
                case PREFAB:
                    return new string[] { ASSET, PREFAB, SCENE };
                case ANIMATOR:
                    return new string[] { ASSET, PREFAB };
                case ANIMATION:
                    return new string[] { ASSET, ANIMATOR, PREFAB };
                case SCRIPT:
                    return new string[] { ASSET, PREFAB };
                case ASSET:
                    return new string[] { ASSET, PREFAB };
                case MESH:
                    return new string[] { ASSET, PREFAB };
                case SHADERSUBGRAPH:
                    return new string[] { SHADERGRAPH };
            }

            return null;
        }

        private static void UpdateProgressBar(float progress)
        {
            const string PROGRESS_TITLE = "Dependency searcher";
            const string PROGRESS_INFO = "Searching...";

            EditorUtility.DisplayProgressBar(PROGRESS_TITLE, PROGRESS_INFO, progress);
        }

        private static void HideProgressBar()
        {
            EditorUtility.ClearProgressBar();
        }

        private static void ShowNotFoundPopup(string[] extensions)
        {
            const string DIALOG_TITLE = "Dependency searcher";
            const string DIALOG_OK = "Ok";

            var dialogMessage = $"No dependency found in files with extensions '{string.Join(", ", extensions)}'";

            EditorUtility.DisplayDialog(DIALOG_TITLE, dialogMessage, DIALOG_OK);
        }
    }
}