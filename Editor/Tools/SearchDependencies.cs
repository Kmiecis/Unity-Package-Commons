using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static class SearchDependencies
    {
        private const string ANIMATION = ".anim";
        private const string ANIMATOR = ".controller";
        private const string ASSET = ".asset";
        private const string FBX = ".fbx";
        private const string JPG = ".jpg";
        private const string MATERIAL = ".mat";
        private const string MESH = ".mesh";
        private const string PNG = ".png";
        private const string PREFAB = ".prefab";
        private const string SCENE = ".unity";
        private const string SCRIPT = ".cs";
        private const string SHADER = ".shader";
        private const string SHADERGRAPH = ".shadergraph";
        private const string SHADERSUBGRAPH = ".shadersubgraph";
        private const string SPRITEATLAS = ".spriteatlas";

        private static readonly Dictionary<string, string[]> Extensions = new Dictionary<string, string[]>()
        {
            { ANIMATION, new string[] { ASSET, ANIMATOR, PREFAB } },
            { ANIMATOR, new string[] { ASSET, PREFAB } },
            { ASSET, new string[] { ASSET, PREFAB } },
            { FBX, new string[] { ASSET, PREFAB } },
            { JPG, new string[] { ASSET, MATERIAL, PREFAB, SPRITEATLAS } },
            { MESH, new string[] { ASSET, PREFAB } },
            { MATERIAL, new string[] { ASSET, PREFAB } },
            { PNG, new string[] { ASSET, MATERIAL, PREFAB, SPRITEATLAS } },
            { PREFAB, new string[] { ASSET, PREFAB, SCENE } },
            { SCRIPT, new string[] { ASSET, PREFAB } },
            { SHADER, new string[] { MATERIAL } },
            { SHADERGRAPH, new string[] { MATERIAL } },
            { SHADERSUBGRAPH, new string[] { SHADERGRAPH } },
        };

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

            var searchExtensions = Extensions[assetExtension];
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
            using var reader = new StreamReader(file);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains(search))
                {
                    return AssetDatabase.LoadAssetAtPath<Object>(file);
                }
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