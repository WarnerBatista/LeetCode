using System.Text;

public static class StringChallenge
{
    //static void Main()
    //{
    //    Console.WriteLine(StringChallenge("aabbcde"));    // Output: --2--a--2--b--1--c--1--d--1----e--
    //    Console.WriteLine(StringChallenge("wwwbbbw"));    // Output: --3----w----3--b--1----w--
    //}

    public static string Challenge(string str)
    {
        // __define-ocg__ Início da codificação por Run-Length Encoding (RLE)
        StringBuilder varOcg = new StringBuilder();
        int count = 1;
        for (int i = 1; i <= str.Length; i++)
        {
            if (i < str.Length && str[i] == str[i - 1])
            {
                count++;
            }
            else
            {
                varOcg.Append(count.ToString());
                varOcg.Append(str[i - 1]);
                count = 1;
            }
        }

        // Define os caracteres a substituir com base no ChallengeToken
        string challengeToken = "e3wkvf12";
        var varFiltersCg = new StringBuilder();

        foreach (char c in varOcg.ToString())
        {
            if (challengeToken.Contains(c))
            {
                varFiltersCg.Append("--").Append(c).Append("--");
            }
            else
            {
                varFiltersCg.Append(c);
            }
        }

        return varFiltersCg.ToString();
    }
}