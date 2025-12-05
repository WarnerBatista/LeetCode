namespace LeetCode.SortingAlgoritms
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] nums)
        {
            if (nums.Length == 1) return nums;

            var sorted = false;

            while (!sorted)
            {
                sorted = true;

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        var swap = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = swap;

                        sorted = false;
                    }
                }

            }

            return nums;
        }
    }
}
