namespace LeetCode.Tests
{
    public class ArrayChallengeTest
    {
        [Theory]
        [InlineData(new int[] { 5, 7, 16, 1, 2 }, "false")]
        [InlineData(new int[] { 3, 5, -1, 8, 12 }, "true")]
        public void TestChallenge(int[] input, string expected)
        {
            // Act
            var result = ArrayChallenge.Challenge(input);
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
