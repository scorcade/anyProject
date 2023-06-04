using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leedCode
{
    internal class _121_____Best_Time_to_Buy_and_Sell_Stock
    {
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int min = int.MaxValue;
            int profit = 0;
            int l = prices.Length;

            for (int i = 0; i < l; i++)
            {
                profit = Math.Max(profit, prices[i] - min);
                min = Math.Min(min, prices[i]);
            }
            return profit;
        }
    }
}
