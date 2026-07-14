using System;

namespace Common
{
    public static class DateTimeExtensions
    {
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1);

        public static int ToTimestamp(this DateTime self)
        {
            return (int)(self.Subtract(Epoch)).TotalSeconds;
        }
    }
}