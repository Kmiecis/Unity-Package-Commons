using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Collections
{
	public class Array3<T>
	{
		private Vector3Int m_Extents;
		private T[] m_Array;

		public Vector3Int Extents
			=> m_Extents;

		public T[] Array
			=> m_Array;

		public int Width
			=> Extents.x;

		public int Height
			=> Extents.y;

		public int Length
			=> Width * Height;

		public Array3(Vector3Int extents)
		{
			m_Extents = extents;
			m_Array = new T[extents.x * extents.y];
		}

		public Array3(int width, int height, int depth)
			: this(new Vector3Int(width, height, depth))
		{
		}

		public T this[int x, int y, int z]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get { return m_Array[z * m_Extents.y * m_Extents.x + y * m_Extents.x + x]; }
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set { m_Array[z * m_Extents.y * m_Extents.x + y * m_Extents.x + x] = value; }
		}

		public T this[Vector3Int xyz]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get { return this[xyz.x, xyz.y, xyz.z]; }
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set { this[xyz.x, xyz.y, xyz.z] = value; }
		}
	}
}