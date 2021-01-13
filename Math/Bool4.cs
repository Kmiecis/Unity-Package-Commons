using System;
using System.Runtime.CompilerServices;

namespace Common
{
	[Serializable]
	public struct Bool4 : IEquatable<Bool4>
	{
		public bool x;
		public bool y;
		public bool z;
		public bool w;

		public static readonly Bool4 False = new Bool4(false, false, false, false);
		public static readonly Bool4 True = new Bool4(true, true, true, true);

		public Bool4(bool x, bool y, bool z, bool w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public Bool4(bool b) :
			this(b, b, b, b)
		{
		}

		public Bool4(Bool4 b) :
			this(b.x, b.y, b.z, b.w)
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
					case 2: return z;
					case 3: return w;
					default:
						throw new IndexOutOfRangeException($"Invalid Bool4 index {index}");
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
						throw new IndexOutOfRangeException($"Invalid Bool4 index {index}");
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Any()
		{
			return (
				this.x ||
				this.y ||
				this.z ||
				this.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool All()
		{
			return (
				this.x &&
				this.y &&
				this.z &&
				this.w
			);
		}

		public bool Equals(Bool4 other)
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
			return obj is Bool4 && Equals((Bool4)obj);
		}

		public override int GetHashCode()
		{
			return x.GetHashCode() | (y.GetHashCode() << 1) | (z.GetHashCode() << 2) | (w.GetHashCode() << 3);
		}

		public override string ToString()
		{
			return string.Format("Bool4({0}, {1}, {2}, {3})", x, y, z, w);
		}
	}
}