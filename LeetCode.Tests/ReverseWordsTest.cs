namespace LeetCode.Tests
{
    public class ReverseWordsTest
    {
        [Theory]
        [InlineData("the sky is blue", "blue is sky the")]
        [InlineData("  hello world  ", "world hello")]
        [InlineData("a good   example", "example good a")]
        public void ReverseWordsInString_ShouldWorkAsExpected(string s, string expected)
        {
            var result = ReverseWords.ReverseWordsInString(s);
            Assert.Equal(expected, result);
        }
    }
}
