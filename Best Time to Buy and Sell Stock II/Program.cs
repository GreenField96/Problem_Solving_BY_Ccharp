internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, this is solution for: Best Time to Buy and Sell Stock II \n!");
        Solution sol001 =  new Solution();
        //int[] arr = { 1, 2, 3, 4, 5 };
        int[] arr = {7,1,5,3,6,4};

        int profit = sol001.MaxProfit(arr);
        Console.WriteLine("profit is > " + profit );
    }
}

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int l = 0;
        int profit = 0;
        for (int r = 1; r < prices.Count(); r++)
        {
            if (prices[l] < prices[r])
            {
                profit += prices[r] - prices[l];
            }
            l++;
        }
        return profit;
    }
}