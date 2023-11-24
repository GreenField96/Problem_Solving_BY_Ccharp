internal class Program
{
    private static void Main(string[] args)
    {
      
      int[] nums = { 1, 2, 3, 4 };
     
      Solution s1 = new Solution();
      int[] results =  s1.RunningSum(nums);

      foreach(int result in results){
           Console.WriteLine(result);
      }
    }
}
public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int sum = 0;
        int[] numsSum = new int[nums.Count()];
        for (int i = 0; i < nums.Count(); i++)
        {
            sum += nums[i];
            numsSum[i] = sum;
        }
        return numsSum;
    }
}