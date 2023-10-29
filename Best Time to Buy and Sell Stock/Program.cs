using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, this is solution for: Best Time to Buy and Sell Stock II \n!");
        Solution sol001 = new Solution();
        //int[] arr = { 1, 2, 3, 4, 5 };
        int[] arr = { 7, 1, 5, 3, 6, 4 };
        int profit = sol001.MaxProfit(arr);
        Console.WriteLine("profit is > " + profit);
    }
}

public class Solution
{

    public int MaxProfit(int[] prices)
    {
        int mxProfit = 0;
        int mxStart = 0, r = 0, l = 0;
        for (int mxEnd = 1; mxEnd < prices.Count(); mxEnd++)
        {
            l = prices[mxStart];
            r = prices[mxEnd];
            if (r > l)
            {
                mxProfit = Math.Max(r - l, mxProfit);
            }
            else
            {
                mxStart = mxEnd;
            }
        }
        return mxProfit;
    }

}