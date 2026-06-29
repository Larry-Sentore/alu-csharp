using System;

namespace Text
{
    /// <summary> Provides string utility methods </summary>
    public class Str
    {
        /// <summary> Returns the number of words in a camelCase string </summary>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int wordCount = 1;

            foreach (char c in s)
            {
                if (char.IsUpper(c))
                    wordCount++;
            }

            return wordCount;
        }
    }
}
