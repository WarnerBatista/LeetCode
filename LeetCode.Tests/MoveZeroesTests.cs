namespace LeetCode.Tests
{
    public class MoveZeroesTests
    {
        [Theory]
        [InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 0, 0, 1 }, new int[] { 1, 0, 0 })]
        [InlineData(new int[] { 1, 0, 0, 1 }, new int[] { 1, 1, 0, 0 })]
        [InlineData(new int[] { 2, 1 }, new int[] { 2, 1 })]
        public void Move_ShouldMove0ToEndOfArray_AsExpected(int[] nums, int[] expected)
        {
            MoveZeroes.Move(nums);
            Assert.Equal(expected, nums);
        }
    }
}
