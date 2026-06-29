using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary> Provides string utility methods </summary>
    public class Str
    {
        /// <summary> Returns the index of the first non-repeating character in a string, or -1 if none exists </summary>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                    return i;
            }

            return -1;
        }
    }
}
