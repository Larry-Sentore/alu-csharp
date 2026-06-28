using System;
using System.Collections.Generic;

namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // First pass: count character occurrences
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            // Second pass: find the first character with a count of 1
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                    return i;
            }

            return -1;
        }
    }
}
