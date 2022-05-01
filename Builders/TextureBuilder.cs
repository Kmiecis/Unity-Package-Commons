using System;
using UnityEngine;

namespace Common
{
    public class TextureBuilder : IDisposable
    {
        protected Color[] _pixels;

        public TextureBuilder(Color[] pixels)
        {
            _pixels = pixels;
        }

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
        
        public Color this[int i]
        {
            get => GetPixel(i);
            set => SetPixel(i, value);
        }
        
        public void Dispose()
        {
            _pixels = null;
        }
    }

    public class Texture2DBuilder : TextureBuilder
    {
        private int _width;
        private int _height;

        public Texture2DBuilder(int width, int height) :
            base(new Color[width * height])
        {
            _width = width;
            _height = height;
        }

        public Color GetPixel(int x, int y)
        {
            return _pixels[x + y * _width];
        }

        public void SetPixel(int x, int y, Color c)
        {
            _pixels[x + y * _width] = c;
        }

        public Color this[int x, int y]
        {
            get => GetPixel(x, y);
            set => SetPixel(x, y, value);
        }

        public virtual void Overwrite(Texture2D texture)
        {
            texture.SetPixels(_pixels);
            texture.Apply();
        }
    }

    public class Texture3DBuilder : TextureBuilder
    {
        private int _width;
        private int _height;
        private int _depth;

        public Texture3DBuilder(int width, int height, int depth) :
            base(new Color[width * height * depth])
        {
            _width = width;
            _height = height;
            _depth = depth;
        }

        public Color GetPixel(int x, int y, int z)
        {
            return _pixels[x + y * _width + z * _height];
        }

        public void SetPixel(int x, int y, int z, Color c)
        {
            _pixels[x + y * _width + z * _height] = c;
        }

        public Color this[int x, int y, int z]
        {
            get => GetPixel(x, y, z);
            set => SetPixel(x, y, z, value);
        }

        public virtual void Overwrite(Texture3D texture)
        {
            texture.SetPixels(_pixels);
            texture.Apply();
        }
    }
}
