namespace LeetCode
{
    public static class IsSubsequence
    {
        public static bool Validate(string s, string t)
        {
            if (s.Length == 0)
                return true;

            if (t.Length == 0 && s.Length != 0)
                return false;

            var j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                while (j < t.Length)
                {
                    if (s[i] == t[j++])
                    {
                        if (i == s.Length - 1)
                            return true;
                        else
                            break;
                    }
                    else if (j == t.Length)
                        return false;
                }
            }

            return false;
        }

        //Resolved by Copilot
        public static bool Validate2(string s, string t)
        {
            return s.Length == 0 || (t.Length != 0 && (s[0] == t[0] ? Validate(s[1..], t[1..]) : Validate(s, t[1..])));
        }
    }
}
