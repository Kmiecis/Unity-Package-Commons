using System.Collections.Generic;
using UnityEngine;

namespace Common.Extensions
{
    public static class Texture2DExtensions
    {
        public static void ResampleAndCrop(this Texture2D self, int targetWidth, int targetHeight)
        {
            int sourceWidth = self.width;
            int sourceHeight = self.height;

            float sourceAspect = (float)sourceWidth / sourceHeight;
            float targetAspect = (float)targetWidth / targetHeight;

            int xOffset = 0;
            int yOffset = 0;

            float factor;
            if (sourceAspect > targetAspect)
            {   // crop width
                factor = (float)targetHeight / sourceHeight;
                xOffset = (int)((sourceWidth - sourceHeight * targetAspect) * 0.5f);
            }
            else
            {   // crop height
                factor = (float)targetWidth / sourceWidth;
                yOffset = (int)((sourceHeight - sourceWidth / targetAspect) * 0.5f);
            }

            var sourcePixels = self.GetPixels32();
            var targetPixels = new Color32[targetWidth * targetHeight];

            for (int y = 0; y < targetHeight; y++)
            {
                float yPos = y / factor + yOffset;

                int y1 = (int)yPos;
                if (y1 >= sourceHeight)
                {
                    y1 = sourceHeight - 1;
                    yPos = y1;
                }

                int y2 = y1 + 1;
                if (y2 >= sourceHeight)
                    y2 = sourceHeight - 1;

                float fy = yPos - y1;
                y1 *= sourceWidth;
                y2 *= sourceWidth;

                for (int x = 0; x < targetWidth; x++)
                {
                    float xPos = x / factor + xOffset;

                    int x1 = (int)xPos;
                    if (x1 >= sourceWidth)
                    {
                        x1 = sourceWidth - 1;
                        xPos = x1;
                    }

                    int x2 = x1 + 1;
                    if (x2 >= sourceWidth)
                        x2 = sourceWidth - 1;

                    float fx = xPos - x1;

                    var c11 = sourcePixels[x1 + y1];
                    var c12 = sourcePixels[x1 + y2];
                    var c21 = sourcePixels[x2 + y1];
                    var c22 = sourcePixels[x2 + y2];

                    float f11 = (1 - fx) * (1 - fy);
                    float f12 = (1 - fx) * fy;
                    float f21 = fx * (1 - fy);
                    float f22 = fx * fy;

                    float r = c11.r * f11 + c12.r * f12 + c21.r * f21 + c22.r * f22;
                    float g = c11.g * f11 + c12.g * f12 + c21.g * f21 + c22.g * f22;
                    float b = c11.b * f11 + c12.b * f12 + c21.b * f21 + c22.b * f22;
                    float a = c11.a * f11 + c12.a * f12 + c21.a * f21 + c22.a * f22;

                    int index = x + y * targetWidth;

                    targetPixels[index].r = (byte)r;
                    targetPixels[index].g = (byte)g;
                    targetPixels[index].b = (byte)b;
                    targetPixels[index].a = (byte)a;
                }
            }

            self.Reinitialize(targetWidth, targetHeight);
            self.SetPixels32(targetPixels);
            self.Apply(true);
        }

        public static void ResampleAndLetterbox(this Texture2D self, int targetWidth, int targetHeight, Color background)
        {
            int sourceWidth = self.width;
            int sourceHeight = self.height;

            float sourceAspect = (float)sourceWidth / sourceHeight;
            float targetAspect = (float)targetWidth / targetHeight;

            float xOffset = 0.0f;
            float yOffset = 0.0f;
            float factor;

            if (sourceAspect > targetAspect)
            {   // letterbox height
                factor = (float)targetWidth / sourceWidth;
                yOffset = ((sourceHeight - sourceWidth / targetAspect) * 0.5f);
            }
            else
            {   //letterbox width
                factor = (float)targetHeight / sourceHeight;
                xOffset = ((sourceWidth - sourceHeight * targetAspect) * 0.5f);
            }

            var sourcePixels = self.GetPixels32();
            var targetPixels = new Color32[targetWidth * targetHeight];

            for (int y = 0; y < targetHeight; y++)
            {
                float yPos = y / factor + yOffset;
                int y1 = (int)yPos;
                if ((y1 >= sourceHeight) || (y1 < 0))
                {
                    int index = y * targetWidth;
                    for (int x = 0; x < targetWidth; x++)
                    {
                        targetPixels[index + x] = background;
                    }
                    continue;
                }

                int y2 = y1 + 1;
                float fy = yPos - y1;
                if (y2 >= sourceHeight)
                    y2 = sourceHeight - 1;

                y1 *= sourceWidth;
                y2 *= sourceWidth;

                for (int x = 0; x < targetWidth; x++)
                {
                    int index = x + y * targetWidth;

                    float xPos = x / factor + xOffset;
                    int x1 = (int)xPos;
                    if ((x1 >= sourceWidth) || (x1 < 0))
                    {
                        targetPixels[index] = background;
                        continue;
                    }

                    int x2 = x1 + 1;
                    if (x2 >= sourceWidth)
                        x2 = sourceWidth - 1;

                    float fx = xPos - x1;

                    var c11 = sourcePixels[x1 + y1];
                    var c12 = sourcePixels[x1 + y2];
                    var c21 = sourcePixels[x2 + y1];
                    var c22 = sourcePixels[x2 + y2];

                    float f11 = (1 - fx) * (1 - fy);
                    float f12 = (1 - fx) * fy;
                    float f21 = fx * (1 - fy);
                    float f22 = fx * fy;

                    float r = c11.r * f11 + c12.r * f12 + c21.r * f21 + c22.r * f22;
                    float g = c11.g * f11 + c12.g * f12 + c21.g * f21 + c22.g * f22;
                    float b = c11.b * f11 + c12.b * f12 + c21.b * f21 + c22.b * f22;
                    float a = c11.a * f11 + c12.a * f12 + c21.a * f21 + c22.a * f22;

                    targetPixels[index].r = (byte)r;
                    targetPixels[index].g = (byte)g;
                    targetPixels[index].b = (byte)b;
                    targetPixels[index].a = (byte)a;
                }
            }

            self.Reinitialize(targetWidth, targetHeight);
            self.SetPixels32(targetPixels);
            self.Apply(true);
        }

        public static void SwapColors(this Texture2D self, Color color, Color swap)
        {
            var pixels = self.GetPixels();

            for (int i = 0; i < pixels.Length; ++i)
            {
                if (pixels[i] == color)
                {
                    pixels[i] = swap;
                }
            }

            self.SetPixels(pixels);
            self.Apply();
        }

        public static void FloodFillArea(this Texture2D self, int sx, int sy, Color fill)
        {
            int width = self.width;
            int height = self.height;
            
            var pixels = self.GetPixels();
            var refColor = pixels[sx + sy * width];

            var nodes = new Queue<Vector2Int>();
            nodes.Enqueue(new Vector2Int(sx, sy));

            while (nodes.Count > 0)
            {
                var current = nodes.Dequeue();

                for (int i = current.x; i < width; i++)
                {
                    var pixel = pixels[i + current.y * width];
                    if (pixel != refColor || pixel == fill)
                        break;

                    pixels[i + current.y * width] = fill;

                    if (current.y + 1 < height)
                    {
                        pixel = pixels[i + current.y * width + width];
                        if (pixel == refColor && pixel != fill)
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y + 1));
                        }
                    }

                    if (current.y - 1 >= 0)
                    {
                        pixel = pixels[i + current.y * width - width];
                        if (pixel == refColor && pixel != fill)
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y - 1));
                        }
                    }
                }

                for (int i = current.x - 1; i >= 0; i--)
                {
                    var pixel = pixels[i + current.y * width];
                    if (pixel != refColor || pixel == fill)
                        break;

                    pixels[i + current.y * width] = fill;

                    if (current.y + 1 < height)
                    {
                        pixel = pixels[i + current.y * width + width];
                        if (pixel == refColor && pixel != fill)
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y + 1));
                        }
                    }

                    if (current.y - 1 >= 0)
                    {
                        pixel = pixels[i + current.y * width - width];
                        if (pixel == refColor && pixel != fill)
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y - 1));
                        }
                    }
                }
            }

            self.SetPixels(pixels);
            self.Apply();
        }

        public static void FloodFillBorder(this Texture2D self, int sx, int sy, Color fill, Color border)
        {
            int width = self.width;
            int height = self.height;

            var pixels = self.GetPixels();
            var checks = new byte[pixels.Length];
            var refColor = border;

            var nodes = new Queue<Vector2Int>();
            nodes.Enqueue(new Vector2Int(sx, sy));

            while (nodes.Count > 0)
            {
                var current = nodes.Dequeue();

                for (int i = current.x; i < width; i++)
                {
                    if (checks[i + current.y * width] > 0 || pixels[i + current.y * width] == refColor)
                        break;

                    pixels[i + current.y * width] = fill;
                    checks[i + current.y * width] = 1;

                    if (current.y + 1 < height)
                    {
                        if (checks[i + current.y * width + width] == 0 && pixels[i + current.y * width + width] != refColor)
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y + 1));
                        }
                    }

                    if (current.y - 1 >= 0)
                    {
                        if (checks[i + current.y * width - width] == 0 && pixels[i + current.y * width - width] != refColor)
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y - 1));
                        }
                    }
                }

                for (int i = current.x - 1; i >= 0; i--)
                {
                    if (checks[i + current.y * width] > 0 || pixels[i + current.y * width] == refColor)
                        break;

                    pixels[i + current.y * width] = fill;
                    checks[i + current.y * width] = 1;

                    if (current.y + 1 < height)
                    {
                        if (checks[i + current.y * width + width] == 0 && pixels[i + current.y * width + width] != refColor)
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y + 1));
                        }
                    }
                    if (current.y - 1 >= 0)
                    {
                        if (checks[i + current.y * width - width] == 0 && pixels[i + current.y * width - width] != refColor)
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y - 1));
                        }
                    }
                }
            }

            self.SetPixels(pixels);
            self.Apply();
        }
    }
}