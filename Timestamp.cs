using System;

namespace Common
{
	public class Timestamp
	{
		public static readonly DateTime Epoch = new DateTime(1970, 1, 1);
		
		public static double NowUtc
		{
			get { return DateTime.UtcNow.Subtract(Epoch).TotalSeconds; }
		}

		public static double Now
		{
			get { return DateTime.Now.Subtract(Epoch).TotalSeconds; }
		}
	}
}
