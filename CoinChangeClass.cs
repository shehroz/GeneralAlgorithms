﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class CoinChangeClass
    {
        public static int CoinChange(int[] coins, int amount)
        {
            Array.Sort(coins);
            int[] dp = new int[amount + 1];
            Array.Fill(dp, amount + 1);
            dp[0] = 0;
            for (int i = 0; i <= amount; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= i)
                        dp[i] = Math.Min(dp[i], 1 + dp[i - coins[j]]);
                    else
                        break;
                }
            }

            return dp[amount] > amount ? -1 : dp[amount];
        }
    }
}
