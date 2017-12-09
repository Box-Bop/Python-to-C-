using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 11, 15, 6, 13, 13, 25, 32, 11, 20, 5, 31, 16, 32, 29, 11, 13, 3, 29, 28, 24 };
            int[] nums2 = new int[] { 5, 19, 16, 4, 12, 7, 2, 28, 34, 29, 29, 36, 6, 8, 24, 18, 31, 7, 1, 7 };
            Console.WriteLine("Esimese list'i suurim number: " + nums1.Max());
            Console.WriteLine("Teise list'i suurim number: " + nums2.Max());

            Console.ReadLine();
        }
    }
}
