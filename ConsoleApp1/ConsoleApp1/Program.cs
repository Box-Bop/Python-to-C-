﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 11, 15, 6, 13, 13, 25, 32, 11, 20, 5, 31, 16, 32, 29, 11, 13, 3, 29, 28, 24 };
            int[] nums2 = new int[] { 5, 19, 16, 4, 12, 7, 2, 28, 34, 29, 29, 36, 6, 8, 24, 18, 31, 7, 1, 7 };
            Console.WriteLine("Sarnased elemendid mõlemast list'ist");
            foreach (int num1 in nums1)
            {
                foreach (int num2 in nums2)
                {
                    if (num1 == num2)
                    {
                        Console.WriteLine(num1);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
