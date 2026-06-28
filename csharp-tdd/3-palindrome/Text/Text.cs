using System;
using System.Text;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            if (s == null)
                return false;

            StringBuilder cleaned = new StringBuilder();

            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                    cleaned.Append(char.ToLower(c));
            }

            string cleanedStr = cleaned.ToString();
            int left = 0;
            int right = cleanedStr.Length - 1;

            while (left < right)
            {
                if (cleanedStr[left] != cleanedStr[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }
    }
}
