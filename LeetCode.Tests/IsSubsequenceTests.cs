namespace LeetCode.Tests
{
    public class IsSubsequenceTests
    {
        [Theory]
        [InlineData("abc", "ahbgdc", true)]
        [InlineData("axc", "ahbgdc", false)]
        [InlineData("", "ahbgdc", true)]
        [InlineData("abc", "", false)]
        [InlineData("", "", true)]
        [InlineData("acb", "ahbgdc", false)]
        [InlineData("b", "abc", true)]
        public void Validate_ShouldReturnExpectedResult(string s, string t, bool expected)
        {
            // Act
            var result = IsSubsequence.Validate(s, t);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
