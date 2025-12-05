namespace LeetCode.Tests
{
    public class GreatestCommonDivisorOfStringsTest
    {
        [Theory]
        [InlineData("ABCABC", "ABC", "ABC")]
        [InlineData("ABABAB", "ABAB", "AB")]
        [InlineData("TAXXTAXX", "TAXXTAXXTAXX", "TAXX")]
        public void GcdOfStrings_ShouldReturnCommonDivisor_WhenExists(string str1, string str2, string expected)
        {
            var result = GreatestCommonDivisorOfStrings.GcdOfStrings(str1, str2);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("LEET", "CODE")]
        [InlineData("ABCDEF", "ABC")]
        public void GcdOfStrings_ShouldReturnStringEmpty_WhenDoesntExistsACommonDivisor(string str1, string str2)
        {
            var result = GreatestCommonDivisorOfStrings.GcdOfStrings(str1, str2);

            Assert.Equal(string.Empty, result);
        }

        [Theory]
        [InlineData(8, 12, 4)]
        [InlineData(15, 25, 5)]
        [InlineData(48, 18, 6)]
        [InlineData(9, 6, 3)]
        [InlineData(7, 3, 1)]
        [InlineData(100, 75, 25)]
        public void GCD_ShouldReturnCorrectGCD(int a, int b, int expected)
        {
            var result = GreatestCommonDivisorOfStrings.GCD(a, b);
            Assert.Equal(expected, result);
        }
    }
}