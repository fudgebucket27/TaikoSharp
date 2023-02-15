using System;
using System.Collections.Generic;
using System.Text;

namespace TaikoSharp.Helpers
{
    public static class Conversions
    {
        public static long ToLongFromHexString(string number)
        {
            return long.Parse(number.Substring(2), System.Globalization.NumberStyles.HexNumber);
        }
    }
}
