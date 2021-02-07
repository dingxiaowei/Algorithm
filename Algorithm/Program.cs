using System;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 4, 2, 8, 1, 3, 7, 9, 6 };
            //Sorting.QuickSort(ref nums, 0, nums.Count);
            Sorting.BubbleSort(ref nums);
            foreach (var n in nums)
            {
                Console.WriteLine(n);
            }
            Console.Read();
        }
    }
}
