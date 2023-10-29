using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
        printArrWithMessage("before process : ", nums);
        Solution s1 = new Solution();
        int[] k = (int[])s1.FindDisappearedNumbers(nums);
        printArrWithMessage("After process : ", k);
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
    public IList<int> FindDisappearedNumbers(int[] nums)
    {

        int[] sortedArr = SortArray(nums, 0, (nums.Count() - 1));
        HashSet<int> uniqueNumbers = new HashSet<int>(sortedArr);
        ArrayList arrayList = new ArrayList();
        int i = 1;
        while (nums.Count() >= i)
        {
            if (!uniqueNumbers.Contains(i))
            {
                arrayList.Add(i);
            }
            i++;
        }
        return arrayList.ToArray(typeof(int)) as int[];
    }
    //this is a QickSort function & i take it from internet ;)
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