using System;

namespace DesafioApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public bool DetectCapitalUse(string word)
        {
            if (string.IsNullOrEmpty(word) || word.Length > 100)
                return false;

            int uppercaseCount = 0;
            foreach (char c in word)
            {
                if (char.IsUpper(c))
                    uppercaseCount++;
            }
            return uppercaseCount == word.Length ||
                uppercaseCount == 0 ||
                (uppercaseCount == 1 && char.IsUpper(word[0]));
        }
    }
}