namespace LeetCode
{
    public static class ProductExceptSelf
    {
        public static int[] Execute(int[] nums)
        {
            var answer = new int[nums.Length];

            if (nums.Length == 2)
            {
                answer[0] = nums[1];
                answer[1] = nums[0];
                return answer;
            }

            var preFix = new int[nums.Length];
            var postFix = new int[nums.Length];

            for (var i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    preFix[i] = nums[i];
                    continue;
                }

                preFix[i] = preFix[i - 1] * nums[i];
            }

            for (var i = nums.Length - 1; i >= 0; i--)
            {
                if (i == nums.Length - 1)
                {
                    postFix[i] = nums[i];
                    continue;
                }

                postFix[i] = nums[i] * postFix[i + 1];
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    answer[i] = postFix[i + 1] * 1;
                    continue;
                }

                if (i == nums.Length - 1)
                {
                    answer[i] = preFix[i - 1] * 1;
                    continue;
                }

                answer[i] = preFix[i - 1] * postFix[i + 1];
            }

            return answer;
        }
    }
}
