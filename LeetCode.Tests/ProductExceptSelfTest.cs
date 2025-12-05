namespace LeetCode.Tests
{
    public class ProductExceptSelfTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
        [InlineData(new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 })]
        [InlineData(new int[] { 4, 3, 2, 1, 2 }, new int[] { 12, 16, 24, 48, 24 })]
        public void Execute_ShouldReturns_AsExpected(int[] nums, int[] expected)
        {
            var result = ProductExceptSelf.Execute(nums);
            Assert.Equal(expected, result);
        }
    }
}
