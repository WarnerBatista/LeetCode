namespace LeetCode.Tests
{
    public class MergeStringsAlternatelyTest
    {
        [Theory]
        [InlineData("abc", "pqr", "apbqcr")]
        [InlineData("ab", "pqrs", "apbqrs")]
        [InlineData("abcd", "pq", "apbqcd")]
        public void Merge_ShouldReturnMergedString(string word1, string word2, string expected)
        {
            var result = MergeStringsAlternately.Merge(word1, word2);
            Assert.Equal(expected, result);
        }
    }
}
