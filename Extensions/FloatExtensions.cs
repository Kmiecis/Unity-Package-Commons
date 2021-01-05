namespace Common
{
	public static class FloatExtensions
	{
		public static bool TryGetDigits(this float value, out int front, out int back)
		{
			var valueString = value.ToString();
			var split = valueString.Split(',');

			if (split.IsNullOrEmpty())
			{
				split = valueString.Split('.');
			}

			if (split.IsNullOrEmpty())
			{
				front = default;
				back = default;
				return false;
			}

			front = split[0].Length;
			back = split.Length == 2 ? split[1].Length : 0;
			return true;
		}

		public static int GetFrontDigits(this float value)
		{
			if (TryGetDigits(value, out int front, out int back))
				return front;
			return default;
		}

		public static int GetBackDigits(this float value)
		{
			if (TryGetDigits(value, out int front, out int back))
				return back;
			return default;
		}
	}
}