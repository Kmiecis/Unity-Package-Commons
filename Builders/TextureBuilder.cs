using System;
using UnityEngine;

namespace Common
{
    public class TextureBuilder : IDisposable
    {
        protected int _width = 1;
        protected int _height = 1;
        protected int _depth = 1;
        protected Color[] _pixels;

        public Color[] Pixels
        {
            get => _pixels;
            set => _pixels = value;
        }
        
        public Color GetPixel(int i)
        {
            return _pixels[i];
        }

        public void SetPixel(int i, Color c)
        {
            _pixels[i] = c;
        }

        public Color GetPixel(int x, int y)
        {
            return _pixels[x + y * _width];
        }

        public void SetPixel(int x, int y, Color c)
        {
            _pixels[x + y * _width] = c;
        }

        public Color GetPixel(int x, int y, int z)
        {
            return _pixels[x + y * _width + z * _height];
        }

        public void SetPixel(int x, int y, int z, Color c)
        {
            _pixels[x + y * _width + z * _height] = c;
        }

        public Color this[int i]
        {
            get => GetPixel(i);
            set => SetPixel(i, value);
        }

        public Color this[int x, int y]
        {
            get => GetPixel(x, y);
            set => SetPixel(x, y, value);
        }

        public Color this[int x, int y, int z]
        {
            get => GetPixel(x, y, z);
            set => SetPixel(x, y, z, value);
        }

        public TextureBuilder(int width, int height)
        {
            _width = width;
            _height = height;
            _pixels = new Color[width * height];
        }
        
        public TextureBuilder(int width, int height, int depth)
        {
            _width = width;
            _height = height;
            _depth = depth;
            _pixels = new Color[width * height * depth];
        }

        public virtual void Overwrite(Texture2D texture)
        {
            texture.SetPixels(_pixels);
            texture.Apply();
        }

        public virtual void Overwrite(Texture3D texture)
        {
            texture.SetPixels(_pixels);
            texture.Apply();
        }
        
        public void Dispose()
        {
            _pixels = null;
        }
    }
}
