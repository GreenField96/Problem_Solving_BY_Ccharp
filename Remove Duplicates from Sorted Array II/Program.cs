internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums = { 1, 1, 1, 2, 2, 3 };
        printArrWithMessage("before process : ", nums, nums.Count());
        Solution s1 = new Solution();
        int k = s1.RemoveDuplicates(nums);
        printArrWithMessage("After process : ", nums, k);
    }
    public static void printArrWithMessage(String msg, int[] nums, int k)
    {
        int i = 0;
        Console.WriteLine(msg);
        foreach (int num in nums)
        {
            if (i++ >= k)
                break;
            Console.Write(num);
            Console.Write(',');
        }
        Console.WriteLine("--");
    }

}

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {

        HashSet<int> uniqueNumbers1 = new();
        HashSet<int> uniqueNumbers2 = new();
        int i = 0;
        foreach (int num in nums)
        {
            if (uniqueNumbers1.Add(num))
            {
                nums[i++] = num;
            }
            else if (uniqueNumbers2.Add(num))
            {
                nums[i++] = num;
            }
        }
        return (uniqueNumbers1.Count() + uniqueNumbers2.Count());
    }
}