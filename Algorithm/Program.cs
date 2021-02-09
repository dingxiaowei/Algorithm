using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = new List<int> { 4, 2, 8, 1, 3, 7, 9, 6 };
            ////Sorting.QuickSort(ref nums, 0, nums.Count);
            //Sorting.BubbleSort(ref nums, true);
            //foreach (var n in nums)
            //{
            //    Console.WriteLine(n);
            //}

            ///题目描述
            ///•连续输入字符串，请按长度为8拆分每个字符串后输出到新的字符串数组；
            ///•长度不是8整数倍的字符串请在后面补数字0，空字符串不处理。
            //string str;
            //while ((str = Console.ReadLine()) != null && str.Length < 1000)
            //{
            //    int length = str.Length;
            //    int round = 0;
            //    if (length % 8 != 0)
            //        round = length / 8 + 1;
            //    else
            //        round = length / 8;
            //    for (int i = 0; i < round; i++)
            //    {
            //        for (int j = 0; j < 8; j++)
            //        {
            //            if (length > i * 8 + j)
            //                Console.Write(str[i * 8 + j]);
            //            else
            //                Console.Write("0");
            //        }
            //        Console.Write("\n");
            //    }
            //}

            ///写出一个程序，接受一个十六进制的数，输出该数值的十进制表示。
            ///输入0xA 10  0xAA 170
            //string line = null;
            //while ((line = Console.ReadLine()) != null)
            //{
            //    int i = Convert.ToInt32(line, 16); //从某个进制转变成10进制
            //    Console.WriteLine(i);
            //}

            ///功能:输入一个正整数，按照从小到大的顺序输出它的所有质因子（重复的也要列举）（如180的质因子为2 2 3 3 5 ）最后一个数后面也要有空格

            ///写出一个程序，接受一个正浮点数值，输出该数值的近似整数值。如果小数点后数值大于等于5,向上取整；小于5，则向下取整。
            //float num = Convert.ToSingle(Console.ReadLine());
            //int one = (int)num;
            //if (num - one >= 0.5)
            //    one++;
            //Console.Write(one);

            Console.Read();
        }
    }
}
