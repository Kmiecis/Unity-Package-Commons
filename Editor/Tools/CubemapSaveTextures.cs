using Common;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public static partial class CubemapTools
    {
        [MenuItem("Assets/Commons/Cubemap/Save Textures")]
        public static void CubemapSaveTextures()
        {
            const int CUBEMAP_FACE_COUNT = 6;

            foreach (var cubemap in USelection.GetSelected<Cubemap>())
            {
                var assetPath = AssetDatabase.GetAssetPath(cubemap);

                var width = cubemap.width;
                var height = cubemap.height;

                for (int i = 0; i < CUBEMAP_FACE_COUNT; ++i)
                {
                    var texture = new Texture2D(width, height, TextureFormat.RGB24, false);

                    var face = (CubemapFace)i;
                    var pixels = cubemap.GetPixels(face);
                    texture.SetPixels(pixels);

                    var texturePath = UPath.RemoveExtension(assetPath) + "_" + face.ToString().ToLower() + ".png";
                    var bytes = texture.EncodeToPNG();
                    File.WriteAllBytes(texturePath, bytes);

                    texture.Destroy();
                }
            }

            AssetDatabase.Refresh();
        }
    }
}