/**************************************************
 * 文件名：Sorting.cs
 * 创建人：Aladdin
 * WebSite：http://dingxiaowei.cn/
 * 创建时间：2021/2/7 10:02:52
 * 描述：排序类
 **************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Sorting
    {
        /// <summary>
        /// 快速排序
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void QuickSort(ref List<int> nums, int left, int right)
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

        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="nums"></param>
        public static void BubbleSort(ref List<int> nums)
        {
            int length = nums.Count;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        nums[i] = nums[i] + nums[j];
                        nums[j] = nums[i] - nums[j];
                        nums[i] = nums[i] - nums[j];
                    }
                }
            }
        }
    }
}
