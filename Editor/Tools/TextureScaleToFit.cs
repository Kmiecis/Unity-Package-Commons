using Common;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static partial class TextureTools
    {
        [MenuItem("Assets/Commons/Texture2D/Scale To Fit")]
        public static void ScaleToFit()
        {
            foreach (var texture in USelection.GetSelected<Texture2D>())
            {
                var path = AssetDatabase.GetAssetPath(texture);

                var pixels = texture.GetPixels32();
                UTexture2D.Replace(pixels, pixels[0], Color.clear);
                UTexture2D.ScaleToFit(pixels, texture.width, texture.height);
                texture.SetPixels32(pixels);

                var bytes = texture.EncodeToPNG();
                File.WriteAllBytes(path, bytes);
            }

            AssetDatabase.Refresh();
        }
    }
}