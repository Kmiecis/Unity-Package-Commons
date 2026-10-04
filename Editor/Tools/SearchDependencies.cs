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
        private const string RENDER_TEXTURE = ".renderTexture";
        private const string SCENE = ".unity";
        private const string SCRIPT = ".cs";
        private const string SHADER = ".shader";
        private const string SHADERGRAPH = ".shadergraph";
        private const string SHADERSUBGRAPH = ".shadersubgraph";
        private const string SPRITEATLAS = ".spriteatlas";

        private const string GUID_KEY = "guid";
        private const int GUID_LENGTH = 32;

        private static readonly Dictionary<string, string[]> Extensions = new Dictionary<string, string[]>(System.StringComparer.OrdinalIgnoreCase)
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
            { RENDER_TEXTURE, new string[] { ASSET, MATERIAL, PREFAB } },
            { SCRIPT, new string[] { ASSET, PREFAB, SCENE } },
            { SHADER, new string[] { MATERIAL } },
            { SHADERGRAPH, new string[] { MATERIAL } },
            { SHADERSUBGRAPH, new string[] { SHADERGRAPH } },
        };

        private class Asset
        {
            public string name;
            public string guid;
            public string[] searchExtensions;
            public List<string> dependencies = new List<string>();
        }

        [MenuItem("Assets/Commons/Search Dependencies")]
        private static void Search()
        {
            var selectedObjects = Selection.objects;
            if (selectedObjects.Length == 0)
            {
                Debug.LogError("No object selected to search dependencies for");
                return;
            }

            var assets = GetAssets(selectedObjects);
            if (assets.Count == 0)
            {
                return;
            }

            var searchAssets = GetSearchAssets(assets);
            var searchExtensions = searchAssets.ToKeyArray();

            var searchFiles = GetFiles(searchAssets);
            if (searchFiles.Count == 0)
            {
                ShowNoFilesFoundPopup(searchExtensions);
                return;
            }

            var filteredFiles = FilterFiles(searchFiles);
            if (filteredFiles.Length == 0)
            {
                ShowNoDependenciesFoundPopup(searchFiles.Count, searchExtensions);
                return;
            }

            foreach (var asset in assets)
            {
                LogDependencies(asset);
            }

            var selections = new Object[filteredFiles.Length];
            for (int i = 0; i < filteredFiles.Length; ++i)
            {
                var filepath = filteredFiles[i];
                selections[i] = AssetDatabase.LoadAssetAtPath<Object>(filepath);
            }

            Selection.objects = selections;
            foreach (var select in selections)
            {
                EditorGUIUtility.PingObject(select);
            }
        }

        private static List<Asset> GetAssets(Object[] selectedObjects)
        {
            var result = new List<Asset>();
            var assetPaths = new HashSet<string>();

            foreach (var selectedObject in selectedObjects)
            {
                var assetPath = AssetDatabase.GetAssetPath(selectedObject);
                if (!assetPaths.Add(assetPath))
                {
                    continue;
                }

                var assetExtension = Path.GetExtension(assetPath);

                var searchExtensions = Extensions.GetOrDefault(assetExtension);
                if (searchExtensions == null)
                {
                    Debug.LogError($"No search extension found for given selection extension '{assetExtension}'", selectedObject);
                    continue;
                }

                var assetName = Path.GetFileName(assetPath);
                var assetGuid = AssetDatabase.GUIDFromAssetPath(assetPath);
                var asset = new Asset
                {
                    name = assetName,
                    guid = assetGuid.ToString(),
                    searchExtensions = searchExtensions
                };
                result.Add(asset);
            }

            return result;
        }

        private static Dictionary<string, Dictionary<string, Asset>> GetSearchAssets(List<Asset> assets)
        {
            var result = new Dictionary<string, Dictionary<string, Asset>>();

            foreach (var asset in assets)
            {
                foreach (var searchExtension in asset.searchExtensions)
                {
                    var searchAssets = result.GetOrCompute(searchExtension, () => new Dictionary<string, Asset>());
                    searchAssets[asset.guid] = asset;
                }
            }

            return result;
        }

        private static Dictionary<string, Dictionary<string, Asset>> GetFiles(Dictionary<string, Dictionary<string, Asset>> searchAssets)
        {
            var result = new Dictionary<string, Dictionary<string, Asset>>();

            foreach (var entry in searchAssets)
            {
                var files = Directory.GetFiles("Assets", $"*{entry.Key}", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    result[file] = entry.Value;
                }
            }

            return result;
        }

        private static string[] FilterFiles(Dictionary<string, Dictionary<string, Asset>> files)
        {
            var result = new List<string>();

            var current = 0;
            foreach (var entry in files)
            {
                var file = entry.Key;
                var filename = Path.GetFileName(file);

                UpdateProgressBar(filename, current++, files.Count);

                var referencedAssets = GetReferencedAssets(file, entry.Value);
                if (referencedAssets.Count > 0)
                {
                    result.Add(file);

                    foreach (var asset in referencedAssets)
                    {
                        asset.dependencies.Add(file);
                    }
                }
            }

            HideProgressBar();

            return result.ToArray();
        }

        private static HashSet<Asset> GetReferencedAssets(string filepath, Dictionary<string, Asset> assets)
        {
            var result = new HashSet<Asset>();

            using var reader = new StreamReader(filepath);

            string line;
            while (result.Count < assets.Count && (line = reader.ReadLine()) != null)
            {
                var keyIndex = line.IndexOf(GUID_KEY, System.StringComparison.OrdinalIgnoreCase);
                while (keyIndex >= 0)
                {
                    var valueIndex = keyIndex + GUID_KEY.Length;
                    while (valueIndex < line.Length && !char.IsLetterOrDigit(line[valueIndex]))
                    {
                        ++valueIndex;
                    }

                    if (valueIndex + GUID_LENGTH <= line.Length)
                    {
                        var guid = line.Substring(valueIndex, GUID_LENGTH);
                        if (assets.TryGetValue(guid, out var asset))
                        {
                            result.Add(asset);
                        }
                    }

                    keyIndex = line.IndexOf(GUID_KEY, valueIndex, System.StringComparison.OrdinalIgnoreCase);
                }
            }

            return result;
        }

        private static void LogDependencies(Asset asset)
        {
            if (asset.dependencies.Count == 0)
            {
                Debug.LogWarning($"Found no dependencies of {asset.name}");
                return;
            }

            var resultLog = new StringBuilder("Found ")
                .Append(asset.dependencies.Count)
                .Append(" dependencies of ")
                .Append(asset.name)
                .Append(" at the following paths:\n");

            foreach (var filepath in asset.dependencies)
            {
                resultLog.Append(filepath).Append('\n');
            }

            Debug.LogWarning(resultLog);
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