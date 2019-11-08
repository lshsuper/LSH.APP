using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LSH.APP.Code.Generator.Common
{
    public static class StringExtension
    {

        public static string Repeat(this string str, int repeatCount)
        {
            string result = string.Empty;
            for (int i = 0; i < repeatCount; i++)
            {
                result += str;
            }
            return result;
        }

        public static bool IsPath(this string path)
        {
            string pattern = @"^[a-zA-Z]:(((\\(?! )[^/:*?<>\""|\\]+)+\\?)|(\\)?)\s*$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(path);
        }
    }
}
