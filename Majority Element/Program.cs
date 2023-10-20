using System;
using System.Collections.Generic;

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
