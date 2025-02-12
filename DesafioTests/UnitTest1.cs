using Xunit;
using DesafioApp;

namespace DesafioTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestDetectCapitalUse()
        {
            var solution = new Solution();
            Assert.True(solution.DetectCapitalUse("USA"));
            Assert.True(solution.DetectCapitalUse("leetcode"));
            Assert.True(solution.DetectCapitalUse("Google"));
            Assert.False(solution.DetectCapitalUse("FlaG"));
            Assert.False(solution.DetectCapitalUse(""));
            Assert.False(solution.DetectCapitalUse("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
        }
    }
}