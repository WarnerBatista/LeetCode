namespace LeetCode.Tests
{
    public class StringCompressionTests
    {
        [Theory]
        [InlineData(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }, 6)]
        [InlineData(new char[] { 'a' }, 1)]
        [InlineData(new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' }, 4)]
        public void Compress_ShouldReturnAsExpected(char[] chars, int expected)
        {
            var result = StringCompression.Compress(chars);
            Assert.Equal(expected, result);
        }
    }
}
