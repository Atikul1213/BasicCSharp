using System;

namespace TypeConversion
{
    public static class ExtensionMethods
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string UpperAll(this string str)
        {
            string newStr = "";
            foreach (var ch in str)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    var ch1 = (char)(ch - 'a' + 'A');
                    newStr += ch1;
                }
                else if (ch >= 'A' && ch <= 'Z')
                {
                    newStr += ch;
                }
                else
                    newStr += ch;
            }
            return newStr;
        }
    }
}
