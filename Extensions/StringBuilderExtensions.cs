using System;
using System.Text;

namespace Common.Extensions
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder AppendNewLine(this StringBuilder self)
        {
            self.Append(Environment.NewLine);
            return self;
        }
    }
}
