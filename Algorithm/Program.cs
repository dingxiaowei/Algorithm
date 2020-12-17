using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 4, 2, 8, 1, 3, 7, 9, 6 };
            QuickSort(ref nums, 0, nums.Count);
            foreach (var n in nums)
            {
                Console.WriteLine(n);
            }
            Console.Read();
        }

        static void QuickSort(ref List<int> nums, int left, int right)
        {
            if (left < right)
            {
                int i = left;
                int j = right - 1;
                int middle = nums[(left + right) / 2];
                while (true)
                {
                    while (i < right && nums[i] < middle) { i++; } //从左往右找到一个大于中间值的位置
                    while (j > 0 && nums[j] > middle) { j--; } //从右往左找到一个小于中间值的位置

                    if (i == j) break;
                    //交换两个数字
                    nums[i] = nums[i] + nums[j];
                    nums[j] = nums[i] - nums[j];
                    nums[i] = nums[i] - nums[j];
                    if (nums[i] == nums[j]) j--;
                }
                QuickSort(ref nums, left, i);
                QuickSort(ref nums, i + 1, right);
            }
        }

        static void 
    }
}
