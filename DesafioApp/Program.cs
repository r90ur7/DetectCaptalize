using System;

namespace DesafioApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RunTests();
        }

        public static void RunTests()
        {
            var tests = new SolutionTests();
            tests.TestDetectCapitalUse();
            Console.WriteLine("Todos os testes foram executados.");
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

    public class SolutionTests
    {
        public void TestDetectCapitalUse()
        {
            var solution = new Solution();

            RunTest(solution, "USA", true);
            RunTest(solution, "leetcode", true);
            RunTest(solution, "Google", true);
            RunTest(solution, "FlaG", false);
            RunTest(solution, "", false);
            RunTest(solution, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", false);
        }

        private void RunTest(Solution solution, string input, bool expected)
        {
            bool result = solution.DetectCapitalUse(input);
            Console.WriteLine($"Testando: {input}");
            Console.WriteLine($"Esperado: {expected}, Recebido: {result}");
            Console.WriteLine($"Resultado: {(result == expected ? "Passou" : "Falhou")}");
            Console.WriteLine();
        }
    }
}