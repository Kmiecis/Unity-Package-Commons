using System;

namespace Common.Mathematics
{
	[Serializable]
	public struct Bool3
	{
		public bool x;
		public bool y;
		public bool z;

		public Bool3(bool x, bool y, bool z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public Bool3(bool v) :
			this(v, v, v)
		{
		}

		public Bool3(Bool3 o) :
			this(o.x, o.y, o.z)
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
	}
}