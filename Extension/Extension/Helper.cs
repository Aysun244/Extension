using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class Helper
    {
        public static bool IsOdd(this int num)
        {
            return num % 2 == 1;
        }

        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

        public static bool HasDigit(this string str)
        {
            return str.Any(char.IsDigit);
        }
        public static bool CheckPassword(this string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            return hasUpper && hasLower && hasDigit;
        }
       
        public static string ToCapitalize(this string text)
        {
            return Char.ToUpper(text[0]) + text.Substring(1).ToLower();
        }
    }
}
