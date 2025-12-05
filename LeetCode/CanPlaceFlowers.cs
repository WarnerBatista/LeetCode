namespace LeetCode
{
    public static class CanPlaceFlowers
    {
        public static bool Validate(int[] flowerbed, int n)
        {
            var counter = 0;

            if (flowerbed.Length == 1 && flowerbed[0] == 0)
                return n <= 1;

            if (flowerbed[0] == 0 && flowerbed[1] == 0)
            {
                flowerbed[0] = 1;
                counter++;
            }

            for (var i = 1; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 1)
                    continue;

                if (i == flowerbed.Length - 1 && flowerbed[i - 1] == 0 && flowerbed[i] == 0)
                {
                    counter++;
                    continue;
                }

                if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i] = 1;
                    counter++;
                }
            }

            return n <= counter;
        }
    }
}
