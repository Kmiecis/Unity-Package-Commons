using Common.Mathematics;
using System.Collections.Generic;
using UnityEngine;

namespace Common
{
    public static class UTexture2D
    {
        public static void Replace(Color32[] pixels, Color32 refColor, Color32 color)
        {
            for (int i = 0; i < pixels.Length; ++i)
            {
                if (Mathx.IsEqual(pixels[i], refColor))
                {
                    pixels[i] = color;
                }
            }
        }

        public static void Multiply(Color32[] pixels, float multiplier)
        {
            for (int i = 0; i < pixels.Length; ++i)
            {
                var pixel = (Color)pixels[i];
                pixel *= multiplier;
                pixels[i] = (Color32)pixel;
            }
        }

        public static void FloodFillArea(Color32[] pixels, int sx, int sy, int width, int height, Color32 fill)
        {
            var refColor = pixels[sx + sy * width];

            var nodes = new Queue<Vector2Int>();
            nodes.Enqueue(new Vector2Int(sx, sy));

            while (nodes.Count > 0)
            {
                var current = nodes.Dequeue();

                for (int i = current.x; i < width; i++)
                {
                    var pixel = pixels[i + current.y * width];
                    if (!Mathx.IsEqual(pixel, refColor) || Mathx.IsEqual(pixel, fill))
                        break;

                    pixels[i + current.y * width] = fill;

                    if (current.y + 1 < height)
                    {
                        pixel = pixels[i + current.y * width + width];
                        if (Mathx.IsEqual(pixel, refColor) && !Mathx.IsEqual(pixel, fill))
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y + 1));
                        }
                    }

                    if (current.y - 1 >= 0)
                    {
                        pixel = pixels[i + current.y * width - width];
                        if (Mathx.IsEqual(pixel, refColor) && !Mathx.IsEqual(pixel, fill))
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y - 1));
                        }
                    }
                }

                for (int i = current.x - 1; i >= 0; i--)
                {
                    var pixel = pixels[i + current.y * width];
                    if (!Mathx.IsEqual(pixel, refColor) || Mathx.IsEqual(pixel, fill))
                        break;

                    pixels[i + current.y * width] = fill;

                    if (current.y + 1 < height)
                    {
                        pixel = pixels[i + current.y * width + width];
                        if (Mathx.IsEqual(pixel, refColor) && !Mathx.IsEqual(pixel, fill))
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y + 1));
                        }
                    }

                    if (current.y - 1 >= 0)
                    {
                        pixel = pixels[i + current.y * width - width];
                        if (Mathx.IsEqual(pixel, refColor) && !Mathx.IsEqual(pixel, fill))
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y - 1));
                        }
                    }
                }
            }
        }

        public static void FloodFillBorder(Color32[] pixels, int sx, int sy, int width, int height, Color32 fill, Color32 border)
        {
            var checks = new byte[pixels.Length];
            var refColor = border;

            var nodes = new Queue<Vector2Int>();
            nodes.Enqueue(new Vector2Int(sx, sy));

            while (nodes.Count > 0)
            {
                var current = nodes.Dequeue();

                for (int i = current.x; i < width; i++)
                {
                    if (checks[i + current.y * width] > 0 || Mathx.IsEqual(pixels[i + current.y * width], refColor))
                        break;

                    pixels[i + current.y * width] = fill;
                    checks[i + current.y * width] = 1;

                    if (current.y + 1 < height)
                    {
                        if (checks[i + current.y * width + width] == 0 && !Mathx.IsEqual(pixels[i + current.y * width + width], refColor))
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y + 1));
                        }
                    }

                    if (current.y - 1 >= 0)
                    {
                        if (checks[i + current.y * width - width] == 0 && !Mathx.IsEqual(pixels[i + current.y * width - width], refColor))
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y - 1));
                        }
                    }
                }

                for (int i = current.x - 1; i >= 0; i--)
                {
                    if (checks[i + current.y * width] > 0 || Mathx.IsEqual(pixels[i + current.y * width], refColor))
                        break;

                    pixels[i + current.y * width] = fill;
                    checks[i + current.y * width] = 1;

                    if (current.y + 1 < height)
                    {
                        if (checks[i + current.y * width + width] == 0 && !Mathx.IsEqual(pixels[i + current.y * width + width], refColor))
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y + 1));
                        }
                    }
                    if (current.y - 1 >= 0)
                    {
                        if (checks[i + current.y * width - width] == 0 && !Mathx.IsEqual(pixels[i + current.y * width - width], refColor))
                        {
                            nodes.Enqueue(new Vector2Int(i, current.y - 1));
                        }
                    }
                }
            }
        }

        public static Color32[] ResampleAndCrop(Color32[] sourcePixels, int sourceWidth, int sourceHeight, int targetWidth, int targetHeight)
        {
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

            return targetPixels;
        }

        public static Color32[] ResampleAndLetterbox(Color32[] sourcePixels, int sourceWidth, int sourceHeight, int targetWidth, int targetHeight, Color background)
        {
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

            return targetPixels;
        }
    }
}