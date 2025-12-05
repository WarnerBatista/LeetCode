using System.Text;

namespace LeetCode
{
    public static class StringCompression
    {
        public static int Compress(char[] chars)
        {
            int write = 0, read = 0;

            while (read < chars.Length)
            {
                char current = chars[read];
                int count = 0;

                while (read < chars.Length && chars[read] == current)
                {
                    read++;
                    count++;
                }

                chars[write++] = current;

                if (count > 1)
                {
                    foreach (char c in count.ToString())
                        chars[write++] = c;
                }
            }

            return write;
        }

        //Resolução com StringBuilder - Não é aceita no Leet Code 443
        public static int CompressWithStringBuilder(char[] chars)
        {
            if (chars.Length == 1)
                return 1;

            var sb = new StringBuilder();
            var count = 1;

            for (var i = 1; i <= chars.Length; i++)
            {
                if (i < chars.Length && chars[i] == chars[i - 1])
                    count++;
                else
                {
                    sb.Append(chars[i - 1]);
                    if (count > 1)
                        sb.Append(count);

                    count = 1;
                }
            }

            var newString = sb.ToString();
            chars = newString.ToCharArray();
            return chars.Length;
        }
    }
}
