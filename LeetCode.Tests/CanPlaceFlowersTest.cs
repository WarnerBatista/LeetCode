namespace LeetCode.Tests
{
    public class CanPlaceFlowersTest
    {
        [Theory]
        [InlineData(new int[] { 1, 0, 0, 0, 1 }, 1, true)]
        [InlineData(new int[] { 1, 0, 0, 0, 1 }, 2, false)]
        [InlineData(new int[] { 1, 0, 0, 0, 1, 0, 0 }, 2, true)]
        public void Execute_ShouldReturnAsExpected(int[] flowerbed, int n, bool expected)
        {
            var result = CanPlaceFlowers.Validate(flowerbed, n);

            Assert.Equal(expected, result);
        }
    }
}
