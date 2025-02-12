using Xunit;
using DesafioApp;
using System;

namespace DesafioTests
{
    public class SolutionTests
    {
        [Fact]
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