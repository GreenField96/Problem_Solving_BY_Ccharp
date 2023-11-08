using System.Collections;

/*O(N) solution
 * 
 public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var set1 = nums1.ToHashSet();
        var set2 = nums2.ToHashSet();

        set1.IntersectWith(set2);

        return set1.ToArray();
    }
}
 */
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums1 = { 9, 4, 9, 8, 4 };
        int[] nums2 = { 4, 9, 5 };
        Solution s1 = new Solution();
        int[] res = s1.Intersection(nums1, nums2);
        printArrWithMessage("After process : ", res);
    }
    public static void printArrWithMessage(String msg, int[] nums)
    {
        int i = 0;
        Console.WriteLine(msg);
        foreach (int num in nums)
        {
            if (i++ >= nums.Count())
                break;
            Console.Write(num);
            Console.Write(',');
        }
        Console.WriteLine("--");
    }
}


public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> intHashSet1 = new HashSet<int>(nums1);
        HashSet<int> intHashSet2 = new HashSet<int>(nums2);

        ArrayList nums = new ArrayList();
        foreach (int item1 in intHashSet1)
        {
            foreach (int item2 in intHashSet2)
            {
                if (item2 == item1)
                {
                    nums.Add(item1);
                    break;
                }
            }
        }

        int[] res = nums.ToArray(typeof(int)) as int[];

        return res;
    }
}
