namespace LeetCode
{
    public static class ReverseWords
    {
        public static string ReverseWordsInString(string s)
        {
            var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(' ', words);
        }
    }
}
