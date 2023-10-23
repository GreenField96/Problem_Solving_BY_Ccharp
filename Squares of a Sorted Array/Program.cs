internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums = {-4, -1, 0, 3, 10};
        printArrWithMessage("before process : ", nums);
        Solution s1 = new Solution();
        nums = s1.SortedSquares(nums);
        printArrWithMessage("After process : ", nums);
    }
    public static void printArrWithMessage(String msg, int[] nums)
    {
        Console.WriteLine(msg);
        foreach (int num in nums)
        {
            Console.Write(num);
            Console.Write(',');
        }
        Console.WriteLine("--");
    }
}

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {

        for (int i = 0; i < nums.Count(); i++)
        {
            nums[i] = (nums[i] * nums[i]);
        }

        nums = SortArray(nums, 0, (nums.Count() - 1));
        return nums;
    }
    public static int[] SortArray(int[] array, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = array[leftIndex];

        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }

            while (array[j] > pivot)
            {
                j--;
            }

            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }

        if (leftIndex < j)
            SortArray(array, leftIndex, j);

        if (i < rightIndex)
            SortArray(array, i, rightIndex);

        return array;
    }
}