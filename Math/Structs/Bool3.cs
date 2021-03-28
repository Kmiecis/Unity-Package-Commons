using System;
using System.Runtime.CompilerServices;

namespace Common
{
    [Serializable]
    public struct Bool3 : IEquatable<Bool3>
    {
        public bool x;
        public bool y;
        public bool z;

        public static readonly Bool3 False = new Bool3(false);
        public static readonly Bool3 True = new Bool3(true);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool3(bool x, bool y, bool z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool3(bool b) :
            this(b, b, b)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool3(Bool3 b) :
            this(b.x, b.y, b.z)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Bool3(bool b)
        {
            return new Bool3(b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator ==(Bool3 left, Bool3 right)
        {
            return new Bool3(
                left.x == right.x,
                left.y == right.y,
                left.z == right.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator ==(Bool3 left, bool right)
        {
            return new Bool3(
                left.x == right,
                left.y == right,
                left.z == right
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator ==(bool left, Bool3 right)
        {
            return new Bool3(
                left == right.x,
                left == right.y,
                left == right.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator !=(Bool3 left, Bool3 right)
        {
            return new Bool3(
                left.x != right.x,
                left.y != right.y,
                left.z != right.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator !=(Bool3 left, bool right)
        {
            return new Bool3(
                left.x != right,
                left.y != right,
                left.z != right
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator !=(bool left, Bool3 right)
        {
            return new Bool3(
                left != right.x,
                left != right.y,
                left != right.z
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
                    case 2: return z;
                    default:
                        throw new IndexOutOfRangeException($"Invalid Bool3 index {index}");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    default:
                        throw new IndexOutOfRangeException($"Invalid Bool3 index {index}");
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any()
        {
            return (
                this.x ||
                this.y ||
                this.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All()
        {
            return (
                this.x &&
                this.y &&
                this.z
            );
        }

        public bool Equals(Bool3 other)
        {
            return (
                this.x == other.x &&
                this.y == other.y &&
                this.z == other.z
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Bool3 && Equals((Bool3)obj);
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() | (y.GetHashCode() << 1) | (z.GetHashCode() << 2);
        }

        public override string ToString()
        {
            return string.Format("Bool3({0}, {1}, {2})", x, y, z);
        }
    }
}