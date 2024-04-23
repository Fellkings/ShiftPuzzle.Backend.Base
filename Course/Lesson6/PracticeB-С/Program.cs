namespace PracticeB_С;

class Program
{
    static void Main()
    {
        int[] array = { -2, 1, -3, 4, -1, 2, 1, -5, 4, 5 };
        int[][] dp = new int[array.Length][];
        for (int i = 0; i < array.Length; i++)
        {
            dp[i] = new int[array.Length];
        }

        int maxSum = maxSubarraySum(array, dp);
        Console.WriteLine("Максимальная сумма подпоследовательности: " + maxSum);
    }

    static int maxSubarraySum(int[] array, int[][] dp)
    {
        for (int i = 0; i < array.Length; i++)
        {
            dp[i][i] = array[i];
        }

        for (int len = 2; len <= array.Length; len++)
        {
            for (int i = 0; i < array.Length - len + 1; i++)
            {
                int j = i + len - 1;
                dp[i][j] = array[j];
                for (int k = i + 1; k < j; k++)
                {
                    dp[i][j] = Math.Max(dp[i][j], dp[i][k] + dp[k][j]);
                }
            }
        }

        return dp[0][array.Length - 1];
    }
}