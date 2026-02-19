using Common;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
            { ASSET, new string[] { ASSET, MATERIAL, PREFAB } },
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
                ShowNoFilesFoundPopup(searchExtensions);
                return;
            }

            var assetGuid = AssetDatabase.GUIDFromAssetPath(assetPath);
            var filteredFiles = FilterFiles(searchFiles, assetGuid.ToString());
            if (filteredFiles.Length == 0)
            {
                ShowNoDependenciesFoundPopup(searchFiles.Length, searchExtensions);
                return;
            }

            var assetName = Path.GetFileName(assetPath);
            var resultLog = new StringBuilder("Found ")
                .Append(filteredFiles.Length)
                .Append(" dependencies of ")
                .Append(assetName)
                .Append(" at the following paths:\n");

            var selections = new Object[filteredFiles.Length];
            for (int i = 0; i < filteredFiles.Length; ++i)
            {
                var filepath = filteredFiles[i];
                selections[i] = AssetDatabase.LoadAssetAtPath<Object>(filepath);

                resultLog.Append(filepath);
            }

            Debug.LogWarning(resultLog);

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

        private static string[] FilterFiles(string[] files, string search)
        {
            var result = new List<string>();

            for (int i = 0; i < files.Length; ++i)
            {
                var file = files[i];
                var filename = Path.GetFileName(file);

                UpdateProgressBar(filename, i, files.Length);

                if (HasText(file, search))
                {
                    result.Add(file);
                }
            }

            HideProgressBar();

            return result.ToArray();
        }

        private static bool HasText(string filepath, string search)
        {
            using var reader = new StreamReader(filepath);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains(search))
                {
                    return true;
                }
            }

            return false;
        }

        private static void UpdateProgressBar(string filename, int current, int count)
        {
            const string PROGRESS_TITLE = "Dependency searcher";
            const string PROGRESS_INFO_FORMAT = "Checking {0} ({1}/{2})";

            var progress = current * 1.0f / count;
            var progressInfo = string.Format(PROGRESS_INFO_FORMAT, filename, current, count);
            EditorUtility.DisplayProgressBar(PROGRESS_TITLE, progressInfo, progress);
        }

        private static void HideProgressBar()
        {
            EditorUtility.ClearProgressBar();
        }

        private static void ShowNoFilesFoundPopup(string[] extensions)
        {
            const string DIALOG_TITLE = "Dependency searcher";
            const string DIALOG_OK = "Ok";

            var dialogMessage = $"No files found with extensions '{extensions.Join(", ")}'";

            EditorUtility.DisplayDialog(DIALOG_TITLE, dialogMessage, DIALOG_OK);
        }

        private static void ShowNoDependenciesFoundPopup(int count, string[] extensions)
        {
            const string DIALOG_TITLE = "Dependency searcher";
            const string DIALOG_OK = "Ok";

            var dialogMessage = $"No dependencies found in {count} files with extensions '{extensions.Join(", ")}'";

            EditorUtility.DisplayDialog(DIALOG_TITLE, dialogMessage, DIALOG_OK);
        }
    }
}