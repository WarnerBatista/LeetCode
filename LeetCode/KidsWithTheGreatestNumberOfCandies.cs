namespace LeetCode
{
    public static class KidsWithTheGreatestNumberOfCandies
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var maxCandies = candies.Max();
            var result = new List<bool>(candies.Length);

            for (var i = 0; i < candies.Length; i++)
            {
                result.Add((candies[i] + extraCandies) >= maxCandies);
            }

            return result;
        }
    }
}
