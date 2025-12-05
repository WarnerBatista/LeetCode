namespace LeetCode.SortingAlgoritms
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] nums)
        {
            if (nums.Length == 1)
                return nums;
            var min = 0;
            var minPosition = 0;

            for (var i = 0; i < nums.Length - 1; i++)
            {
                min = nums[i];
                minPosition = i;

                for (var n = i + 1; n < nums.Length; n++)
                {
                    if (nums[n] < min)
                    {
                        min = nums[n];
                        minPosition = n;
                    }
                }

                nums[minPosition] = nums[i];
                nums[i] = min;
            }

            return nums;
        }
    }
}
