/*Community Solution 
 * public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int lastZeroPos = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                (nums[lastZeroPos], nums[i]) = (nums[i], nums[lastZeroPos]);
                lastZeroPos++;
            }
        }
    }
}*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums = { 0, 1, 0, 0, 12};
        Solution s1 = new Solution();
        printArrWithMessage("before process : ", nums);
        s1.MoveZeroes(nums);
        printArrWithMessage("before process : ", nums);

    }
    public static void printArrWithMessage(String msg, int[] nums)
    {
        Console.WriteLine(msg);
        foreach (int num in nums)
        {
            Console.Write(num);
        }
        Console.WriteLine("--");
    }
}

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        getLastZero(nums);
    }
    public static void swapp(int x, int y, int[] nums)
    {
        nums[x] ^= nums[y];
        nums[y] ^= nums[x];
        nums[x] ^= nums[y];
    }
    public static void getItToLastIndex(int zeroIndex, int[] nums)
    {
        for (int i = zeroIndex; i < (nums.Count() - 1); i++)
        {
            swapp(i, i + 1, nums);
        }
    }
    public static void getLastZero(int[] nums)
    {
        for (int i = (nums.Count() - 1); i >= 0; i--)
        {
            if (nums[i] == 0)
            {
                getItToLastIndex(i, nums);
            }
        }
    }
    public static void printArrWithMessage(String msg, int[] nums)
    {
        Console.WriteLine(msg);
        foreach (int num in nums)
        {
            Console.Write(num);
        }
        Console.WriteLine("--");
    }
}

