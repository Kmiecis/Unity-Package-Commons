using System;

namespace Common.Mathematics
{
	[Serializable]
	public struct Vector4Int
	{
		public int x;
		public int y;
		public int z;
		public int w;

		public Vector4Int(int x, int y, int z, int w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public Vector4Int(int v) :
			this(v, v, v, v)
		{
		}

		public Vector4Int(Vector4Int v) :
			this(v.x, v.y, v.z, v.w)
		{
		}

		public int this[int index]
		{
			get
			{
				switch (index)
				{
					case 0: return x;
					case 1: return y;
					case 2: return z;
					case 3: return w;
					default:
						throw new IndexOutOfRangeException($"Invalid Vector4Int index {index}");
				}
			}
			set
			{
				switch (index)
				{
					case 0: x = value; break;
					case 1: y = value; break;
					case 2: z = value; break;
					case 3: w = value; break;
					default:
						throw new IndexOutOfRangeException($"Invalid Vector4Int index {index}");
				}
			}
		}

		public bool Equals(Vector4Int other)
		{
			return (
				this.x == other.x &&
				this.y == other.y &&
				this.z == other.z &&
				this.w == other.w
			);
		}

		public override bool Equals(object obj)
		{
			return obj is Vector4Int && Equals((Vector4Int)obj);
		}

		public override int GetHashCode()
		{
			return x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode() ^ w.GetHashCode();
		}

		public override string ToString()
		{
			return string.Format("[{0}, {1}, {2}, {3}]", x, y, z, w);
		}
	}
}