using System.Linq;

namespace Extension_Method.Extension
{
    public static class StringExtension
    {
        public static int GetWordCount(this string inputString)
        {
            if (!string.IsNullOrEmpty(inputString))
            {
                string[] words = inputString.Split(' ');
                return words.Count();
            }
            return 0;
        }
    }
}
