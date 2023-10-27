using System;

/*Solution from Community 
   public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
           int p1 = m-1;
           int p2 = n-1;
           int i = m+n-1;

           while(p2>=0)
           {
               if(p1 >=0 && nums1[p1] > nums2[p2])
                   nums1[i--] = nums1[p1--];
               else
                  nums1[i--]= nums2[p2--];
           }
    }
 */

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        /*
        int[] nums1 = { 2, 5, 6 };
        int[] nums2 = { 1, 2, 3, 0, 0, 0 };
        */
        /*
        int[] nums1 = { 1 };
        int[] nums2 = {  };
        */
        int[] nums1 = { 0 };
        int[] nums2 = { 1 };
        /*
        int[] nums1 = { 2, 0 };
        int[] nums2 = { 1 };
        */
        Solution s1 = new Solution();

        s1.Merge(nums1,0,nums2,1);
    }
  
}

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int[] mergedArray = new int[n + m];

        int lastIndexOfNums1 = m > 0 ? nums1[m - 1] : 0;
        int lastIndexOfNums2 = n > 0 ? nums2[n - 1] : 0;
     
        if (lastIndexOfNums1 > lastIndexOfNums2){
            mergedArray = mergeTwoArray(nums2, n, nums1, m);
        }
        else
        {
            mergedArray = mergeTwoArray(nums1, m, nums2, n);
        }

        for (int x = 0; x < m + n; x++)
        {
            for (int y = x + 1; y < (m + n - 1); y++)
            {
                if (mergedArray[x] > mergedArray[y])
                {
                    (mergedArray[x], mergedArray[y]) = (mergedArray[y], mergedArray[x]);
                }
            }
        }
        printArrWithMessage("sorted merged array : ", mergedArray);
    }
    public int[] mergeTwoArray(int[] nums1, int m, int[] nums2, int n)
    {
        int[] mergedArray = new int[n + m];
        int count = 0;
        for (int i = 0; i < m; i++)
        {
            mergedArray[i] = nums1[i];
        }
        for (int i = m; i < n + m; i++)
        {
            mergedArray[i] = nums2[count++];
        }
        return mergedArray;
    }
    public void printArrWithMessage(String msg, int[] nums)
    {
        Console.WriteLine(msg);
        foreach (int num in nums)
        {
            Console.Write(num);
        }
        Console.WriteLine("--");
    }
}