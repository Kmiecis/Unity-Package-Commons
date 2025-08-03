using Common;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static partial class ObjectTools
    {
        [MenuItem("Assets/Commons/Object/Save Preview")]
        public static void ObjectSavePreview()
        {
            const int PreviewSize = 256;

            foreach (var selection in USelection.GetSelected())
            {
                var selectionPath = AssetDatabase.GetAssetPath(selection);
                
                var preview = AssetPreview.GetAssetPreview(selection);
                var pixels = preview.GetPixels32();

                UTexture2D.Replace(pixels, pixels[0], Color.clear);
                var resampled = UTexture2D.ResampleAndCrop(pixels, preview.width, preview.height, PreviewSize, PreviewSize);

                var texture = new Texture2D(PreviewSize, PreviewSize, TextureFormat.RGBA32, false);
                texture.SetPixels32(resampled);

                var texturePath = UPath.RemoveExtension(selectionPath) + "_preview.png";
                var bytes = texture.EncodeToPNG();
                File.WriteAllBytes(texturePath, bytes);

                texture.Destroy();
            }

            AssetDatabase.Refresh();
        }
    }
}