using Xunit;
using LIS.Core;

namespace LIS.Tests
{
    public class LISTests
    {
        [Fact]
        public void TestCase1()
        {
            var input = "6 1 5 9 2";
            var result = LongestIncreasingSubsequence.Find(input);
            Assert.Equal("1 5 9", result);
        }

        [Fact]
        public void IncreasingSequence()
        {
            var input = "1 2 3 4 5";
            var result = LongestIncreasingSubsequence.Find(input);
            Assert.Equal("1 2 3 4 5", result);
        }

        [Fact]
        public void DecreasingSequence()
        {
            var input = "5 4 3 2 1";
            var result = LongestIncreasingSubsequence.Find(input);
            Assert.Equal("5", result);
        }
    }
}
