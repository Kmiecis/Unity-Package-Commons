using System;
using System.Runtime.CompilerServices;

namespace Common
{
	[Serializable]
	public struct Bool2 : IEquatable<Bool2>
	{
		public bool x;
		public bool y;

		public static readonly Bool2 False = new Bool2(false);
		public static readonly Bool2 True = new Bool2(true);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Bool2(bool x, bool y)
		{
			this.x = x;
			this.y = y;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Bool2(bool b) :
			this(b, b)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Bool2(Bool2 b) :
			this(b.x, b.y)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator Bool2(bool b)
		{
			return new Bool2(b);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 operator ==(Bool2 left, Bool2 right)
		{
			return new Bool2(
				left.x == right.x,
				left.y == right.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 operator ==(Bool2 left, bool right)
		{
			return new Bool2(
				left.x == right,
				left.y == right
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 operator ==(bool left, Bool2 right)
		{
			return new Bool2(
				left == right.x,
				left == right.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 operator !=(Bool2 left, Bool2 right)
		{
			return new Bool2(
				left.x != right.x,
				left.y != right.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 operator !=(Bool2 left, bool right)
		{
			return new Bool2(
				left.x != right,
				left.y != right
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 operator !=(bool left, Bool2 right)
		{
			return new Bool2(
				left != right.x,
				left != right.y
			);
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Any()
		{
			return (
				this.x ||
				this.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool All()
		{
			return (
				this.x &&
				this.y
			);
		}

		public bool Equals(Bool2 other)
		{
			return (
				this.x == other.x &&
				this.y == other.y
			);
		}

		public override bool Equals(object obj)
		{
			return obj is Bool2 && Equals((Bool2)obj);
		}

		public override int GetHashCode()
		{
			return x.GetHashCode() | (y.GetHashCode() << 1);
		}

		public override string ToString()
		{
			return string.Format("Bool2({0}, {1})", x, y);
		}
	}
}