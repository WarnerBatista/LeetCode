namespace LeetCode
{
    public static class IncreasingTriplet
    {
        public static bool Increase(int[] nums)
        {
            if (nums.Length < 3) return false;

            var first = int.MaxValue;
            var second = int.MaxValue;

            foreach (var num in nums)
            {
                if (num <= first)
                    first = num;
                else if (num <= second)
                    second = num;
                else
                    return true;
            }

            return false;
        }
    }
}
