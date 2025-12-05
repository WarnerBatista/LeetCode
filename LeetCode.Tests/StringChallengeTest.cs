namespace LeetCode.Tests
{
    public class StringChallengeTest
    {
        [Theory]
        [InlineData("aabbcde", "--2--a--2--b--1--c--1--d--1----e--")]
        [InlineData("wwwbbbw", "--3----w----3--b--1----w--")]
        [InlineData("eeewkffv12", "--3----e----1----w----1----k----2----f----1----v----1----1----1----2--")]
        public void Challenge_ShouldReturnEncodedString(string input, string expected)
        {
            var result = StringChallenge.Challenge(input);
            Assert.Equal(expected, result);
        }
    }
}
