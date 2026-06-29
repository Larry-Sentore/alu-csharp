using System;
using System.Text;

namespace Text
{
    /// <summary> Provides string utility methods </summary>
    public class Str
    {
        /// <summary> Returns true if the input string is a palindrome, ignoring case and non-alphanumeric characters </summary>
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
