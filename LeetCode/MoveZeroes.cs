namespace LeetCode
{
    public static class MoveZeroes
    {
        public static void Move(int[] nums)
        {
            if (nums.Length == 1)
                return;

            var read = 0;
            var write = 0;

            while (read < nums.Length)
            {
                var current = nums[read++];

                if (current == 0)
                {
                    while (write < nums.Length - 1)
                    {
                        nums[write++] = nums[write];
                    }

                    nums[write] = current;
                }

                write = 0;

                while (write <= read && write < nums.Length && nums[write] != 0)
                {
                    write++;
                }
            }
        }
    }
}