namespace LeetCode.Tests
{
    public class KidsWithTheGreatestNumberOfCandiesTest
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 5, 1, 3 }, 3, new bool[] { true, true, true, false, true })]
        [InlineData(new int[] { 4, 2, 1, 1, 2 }, 1, new bool[] { true, false, false, false, false })]
        [InlineData(new int[] { 12, 1, 12 }, 10, new bool[] { true, false, true })]
        public void KidsWithCandies_ShouldReturnExpectedResult(int[] candies, int extraCandies, bool[] expected)
        {
            // Act
            var result = KidsWithTheGreatestNumberOfCandies.KidsWithCandies(candies, extraCandies);
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
