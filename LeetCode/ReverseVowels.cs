using System.Text;

namespace LeetCode
{
    public static class ReverseVowels
    {
        public static string Reverse(string s)
        {
            if (s.Length == 1)
                return s;

            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            List<char> vowelsReverted = new();

            for (var i = s.Length - 1; i >= 0; i--)
            {
                if (vowels.Contains(s[i]))
                    vowelsReverted.Add(s[i]);
            }

            if (vowelsReverted.Count == 0)
                return s;

            var vowelPosition = 0;
            var strReverted = new StringBuilder();

            for (var i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    strReverted.Append(vowelsReverted[vowelPosition]);
                    vowelPosition++;
                }
                else
                    strReverted.Append(s[i]);
            }

            return strReverted.ToString();
        }
    }
}
