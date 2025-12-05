namespace LeetCode.Tests
{
    public class ReverseVowelsTest
    {
        [Theory]
        [InlineData("IceCreAm", "AceCreIm")]
        [InlineData("leetcode", "leotcede")]
        public void Reverse_ShouldReverseAllVowels_AsExpected(string input, string expected)
        {
            var result = ReverseVowels.Reverse(input);

            Assert.Equal(expected, result);
        }
    }
}
