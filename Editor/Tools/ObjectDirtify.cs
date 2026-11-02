using UnityEditor;

namespace CommonEditor
{
    public static partial class ObjectTools
    {
        [MenuItem("Assets/Commons/Object/Dirtify")]
        public static void MarkAsDirty()
        {
            foreach (var selected in USelection.GetSelected())
            {
                var path = AssetDatabase.GetAssetPath(selected);

                if (AssetDatabase.IsValidFolder(path))
                {
                    MarkFolderAsDirty(path);
                }
                else
                {
                    EditorUtility.SetDirty(selected);
                }
            }
        }

        private static void MarkFolderAsDirty(string folder)
        {
            foreach (var asset in UAssetDatabase.LoadAssets(string.Empty, folder))
            {
                EditorUtility.SetDirty(asset);
            }
        }
    }
}