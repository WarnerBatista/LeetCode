namespace LeetCode
{
    public static class ArrayChallenge
    {
        //Console.WriteLine(ArrayChallenge(new int[] { 5, 7, 16, 1, 2 })); // Output: false
        //Console.WriteLine(ArrayChallenge(new int[] { 3, 5, -1, 8, 12 })); // Output: true
        public static string Challenge(int[] arr)
        {
            // __define-ocg__ Separar o maior valor dos demais
            int max = int.MinValue;
            foreach (int num in arr)
            {
                if (num > max)
                    max = num;
            }

            List<int> varFiltersCg = new List<int>();
            foreach (int num in arr)
            {
                if (num != max)
                    varFiltersCg.Add(num);
            }

            // varOcg será usado para armazenar combinações temporárias
            return CanSumToTarget(varFiltersCg.ToArray(), max) ? "true" : "false";
        }

        public static bool CanSumToTarget(int[] varOcg, int target)
        {
            int n = varOcg.Length;
            int subsetCount = 1 << n;

            for (int i = 1; i < subsetCount; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        sum += varOcg[j];
                    }
                }
                if (sum == target)
                    return true;
            }

            return false;
        }
    }
}
