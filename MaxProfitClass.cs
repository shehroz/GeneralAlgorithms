using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAlgorithms
{
    public class MaxProfitClass
    {
        //only one If you were only permitted to complete at most one transaction (i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.
        public int MaxProfit(int[] prices)
        {
            int min = int.MaxValue;
            int max = 0;
            for (int i = 0; i < prices.Length; i++)
                if (prices[i] < min)
                    min = prices[i];
                else
                    max = Math.Max(max, prices[i] - min);

            return max;
        }
        //Design an algorithm to find the maximum profit. You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times).
        public int MaxProfit2(int[] prices)
        {
            int min = int.MaxValue;
            int max = 0;
            for (int i = 0; i < prices.Length; i++)
                if (prices[i] < min)
                    min = prices[i];
                else
                    max = Math.Max(max, prices[i] - min);

            return max;
        }
    }
}
