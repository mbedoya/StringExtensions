using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console
{
    public static class BasicStringExtensions
    {
        static string whiteSpace = " ";
        static int notFoundIndexValue = -1;

        public static string ToPascal(this String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            string upperLetter = string.Empty;
            int firstLetterIndex = FindFirstLetterIndex(str);
            if (firstLetterIndex == notFoundIndexValue)
            {
                return str;
            }
            upperLetter = str.Substring(0, firstLetterIndex + 1).ToUpper();

            string unchangedStringPart = String.Empty;
            if (str.Length > firstLetterIndex + 1)
            {
                unchangedStringPart = str.Substring(firstLetterIndex + 1, str.Length - firstLetterIndex - 1);
            }

            return upperLetter + unchangedStringPart;
        }

        private static int FindFirstLetterIndex(string str)
        {
            int index = notFoundIndexValue;
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i, 1) != whiteSpace)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
