using System;
using System.Collections.Generic;

/*
 * Boyer - Moore Voting Algorithm | O(n)
 * 
 public class Solution {
    public int MajorityElement(int[] nums) {
        int candidate = nums[0];
        int count = 1;
        
        for (int i = 1; i < nums.Length; i++) {
            if (count == 0) {
                candidate = nums[i];
                count = 1;
            } else if (candidate == nums[i]) {
                count++;
            } else {
                count--;
            }
        }
        
        return candidate;
    }
}
 */

internal class Program
{
    static void Main(string[] args)
    {
        /*int[] arr = { 1, 2, 3, 2, 4, 1, 5, 4, 1 };*/
        int[] arr = { 1 };

        int elementCount = CountDuplicates(arr);

        Console.WriteLine($"Majority Element is : {elementCount}");
    }

    static int CountDuplicates(int[] nums)
    {
        HashSet<int> distinctNumbers = new();
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int tmp = 0;

        foreach (int number in nums)
        {
            if (!distinctNumbers.Add(number))
            {
                if (!dict.ContainsKey(number))
                    dict.Add(number, 0);

                tmp = dict[number];
                dict[number] =  ++tmp;
            }
        }
        List<int> myList = new List<int>(distinctNumbers);
        
        int maxDuplicateNumber = 0;
        int keyOfMaxDuplicate = myList[0];
        foreach (var item in dict)
        {
            if (maxDuplicateNumber < item.Value)
            {
                maxDuplicateNumber = item.Value;
                keyOfMaxDuplicate = item.Key;
            }
        }

        return keyOfMaxDuplicate;
    }
}
