namespace LeetCode.Tests
{
    public class IncreasingSubsequenceOfLengthKTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4, true)]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, 3, false)]
        [InlineData(new int[] { 2, 1, 5, 0, 4, 6 }, 4, true)]
        public void Execute_ShouldReturnAsExpected(int[] nums, int k, bool expected)
        {
            var result = IncreasingSubsequenceOfLengthK.Execute(nums, k);
            Assert.Equal(expected, result);
        }
    }
}
