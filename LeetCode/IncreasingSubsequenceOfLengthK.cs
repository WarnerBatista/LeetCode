namespace LeetCode
{
    public static class IncreasingSubsequenceOfLengthK
    {
        public static bool Execute(int[] nums, int k)
        {
            List<int> tails = new List<int>();

            foreach (int num in nums)
            {
                int index = tails.BinarySearch(num);
                if (index < 0) index = ~index;

                if (index == tails.Count)
                    tails.Add(num);
                else
                    tails[index] = num;
            }

            return tails.Count >= k;
        }
    }
}
