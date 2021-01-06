using UnityEngine;

namespace Common
{
	public class Texture2DBuilder : ITexture2DBuilder
	{
		private int m_Width;
		private int m_Height;
		private Color32[] m_Pixels;

		public Color32[] Pixels
		{
			get { return m_Pixels; }
		}

		public Color32 this[int i]
		{
			get { return m_Pixels[i]; }
			set { m_Pixels[i] = value; }
		}

		public Color32 this[int x, int y]
		{
			get { return m_Pixels[x + y * m_Width]; }
			set { m_Pixels[x + y * m_Width] = value; }
		}

		public Texture2DBuilder(int width, int height)
		{
			this.m_Width = width;
			this.m_Height = height;
			this.m_Pixels = new Color32[width * height];
		}

		public Texture2D Build()
		{
			var texture = new Texture2D(m_Width, m_Height);
			texture.SetPixels32(m_Pixels);
			texture.Apply();
			return texture;
		}
	}
}