using System;
using System.Collections.Generic;
using System.Linq;

namespace LIS.Core
{
    public class LongestIncreasingSubsequence
    {
        public static string Find(string input)
        {
            var nums = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            int n = nums.Length;
            int[] dp = new int[n];
            int[] prev = new int[n];

            Array.Fill(dp, 1);
            Array.Fill(prev, -1);

            int maxLen = 1;
            int lastIndex = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i] && dp[j] + 1 > dp[i])
                    {
                        dp[i] = dp[j] + 1;
                        prev[i] = j;
                    }
                }

                if (dp[i] > maxLen)
                {
                    maxLen = dp[i];
                    lastIndex = i;
                }
            }

            var result = new List<int>();
            while (lastIndex != -1)
            {
                result.Add(nums[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            result.Reverse();
            return string.Join(" ", result);
        }
    }
}
