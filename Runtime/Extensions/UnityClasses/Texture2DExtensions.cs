using UnityEngine;

namespace Common
{
    public static class Texture2DExtensions
    {
        public static void ScaleToFit(this Texture2D self)
        {
            var pixels = self.GetPixels32();
            var width = self.width;
            var height = self.height;

            UTexture2D.ScaleToFit(pixels, width, height);

            self.SetPixels32(pixels);
            self.Apply(true);
        }

        public static void ResampleAndCrop(this Texture2D self, int targetWidth, int targetHeight)
        {
            var sourcePixels = self.GetPixels32();
            var sourceWidth = self.width;
            var sourceHeight = self.height;

            var targetPixels = UTexture2D.ResampleAndCrop(sourcePixels, sourceWidth, sourceHeight, targetWidth, targetHeight);

            self.Reinitialize(targetWidth, targetHeight);
            self.SetPixels32(targetPixels);
            self.Apply(true);
        }

        public static void ResampleAndLetterbox(this Texture2D self, int targetWidth, int targetHeight, Color background)
        {
            var sourcePixels = self.GetPixels32();
            var sourceWidth = self.width;
            var sourceHeight = self.height;

            var targetPixels = UTexture2D.ResampleAndLetterbox(sourcePixels, sourceWidth, sourceHeight, targetWidth, targetHeight, background);

            self.Reinitialize(targetWidth, targetHeight);
            self.SetPixels32(targetPixels);
            self.Apply(true);
        }

        public static void FloodFillArea(this Texture2D self, int sx, int sy, Color fill)
        {
            var width = self.width;
            var height = self.height;
            var pixels = self.GetPixels32();

            UTexture2D.FloodFillArea(pixels, sx, sy, width, height, fill);

            self.SetPixels32(pixels);
            self.Apply();
        }

        public static void FloodFillBorder(this Texture2D self, int sx, int sy, Color fill, Color border)
        {
            int width = self.width;
            int height = self.height;
            var pixels = self.GetPixels32();

            UTexture2D.FloodFillBorder(pixels, sx, sy, width, height, fill, border);

            self.SetPixels32(pixels);
            self.Apply();
        }
    }
}