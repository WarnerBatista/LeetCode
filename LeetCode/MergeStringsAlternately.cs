using System.Text;

namespace LeetCode
{
    /// <summary>
    /// Leet Code: 1768
    /// </summary>
    public static class MergeStringsAlternately
    {
        public static string Merge(string word1, string word2)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var maxLength = Math.Max(word1.Length, word2.Length);

            var str = new StringBuilder();

            for (var i = 0; i < maxLength; i++)
            {
                if (i < word1.Length)
                    str.Append(word1[i]);

                if (i < word2.Length)
                    str.Append(word2[i]);
            }

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedTicks} ms");
            return str.ToString();
        }
    }
}
