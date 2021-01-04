using System;

namespace Common.Mathematics
{
	[Serializable]
	public struct Bool2
	{
		public bool x;
		public bool y;

		public Bool2(bool x, bool y)
		{
			this.x = x;
			this.y = y;
		}

		public Bool2(bool b) :
			this(b, b)
		{
		}

		public Bool2(Bool2 b) :
			this(b.x, b.y)
		{
		}

		public bool this[int index]
		{
			get
			{
				switch (index)
				{
					case 0: return x;
					case 1: return y;
					default:
						throw new IndexOutOfRangeException($"Invalid Bool2 index {index}");
				}
			}
			set
			{
				switch (index)
				{
					case 0: x = value; break;
					case 1: y = value; break;
					default:
						throw new IndexOutOfRangeException($"Invalid Bool2 index {index}");
				}
			}
		}

		public bool Equals(Bool3 other)
		{
			return this.x == other.x && this.y == other.y;
		}

		public override bool Equals(object obj)
		{
			return obj is Bool2 && Equals((Bool2)obj);
		}

		public override int GetHashCode()
		{
			return x.GetHashCode() ^ y.GetHashCode();
		}

		public override string ToString()
		{
			return string.Format("[{0}, {1}]", x, y);
		}
	}
}