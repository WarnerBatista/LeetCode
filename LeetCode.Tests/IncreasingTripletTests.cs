namespace LeetCode.Tests
{
    public class IncreasingTripletTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, true)]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, false)]
        [InlineData(new int[] { 2, 1, 5, 0, 4, 6 }, true)]
        [InlineData(new int[] { 20, 100, 10, 12, 5, 13 }, true)]
        [InlineData(new int[] { 6, 7, 1, 2 }, false)]
        [InlineData(new int[] { 1, 5, 0, 4, 3 }, false)]
        [InlineData(new int[] { 1, 5, 0, 4, 1, 3 }, true)]
        public void Increase_ShouldReturnAsExpected(int[] nums, bool expected)
        {
            var result = IncreasingTriplet.Increase(nums);

            Assert.Equal(expected, result);
        }
    }
}
