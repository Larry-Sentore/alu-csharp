using System;

namespace Text
{
    public class Str
    {
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int wordCount = 1; // Start with 1 word (the first word)

            foreach (char c in s)
            {
                if (char.IsUpper(c))
                    wordCount++;
            }

            return wordCount;
        }
    }
}
