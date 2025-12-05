using LeetCode.SortingAlgoritms;

namespace LeetCode.Tests.SortingAlgoritms
{
    public class SelectionSortTests
    {
        [Theory]
        [InlineData(new int[] { 7, 5, 1, 8, 3 }, new int[] { 1, 3, 5, 7, 8 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 7, 7, 7, 7, 7, 1, 1, 9, 9, 0, 4, 4, 4, 5, 4, 5, 7, 1 },
            new int[] { 0, 1, 1, 1, 4, 4, 4, 4, 5, 5, 7, 7, 7, 7, 7, 7, 9, 9 })]
        [InlineData(new int[] { 7 }, new int[] { 7 })]
        public void Sort_ShouldReturnIncreasingSortedArray_AsExpected(int[] nums, int[] expected)
        {
            var result = SelectionSort.Sort(nums);
            Assert.Equal(expected, result);
        }
    }
}
