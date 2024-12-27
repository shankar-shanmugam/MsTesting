using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class StringOp
    {
        public static int CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            int vowelCount = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }

    }
}
