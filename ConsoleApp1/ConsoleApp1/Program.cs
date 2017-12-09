using System;
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
            int i, num1, num2;
            Console.WriteLine("sisestage esimene number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisestage teine number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("paarisarvud nende kahe arvu vahel on: ");
            if (num1 % 2 != 0)
            {
                num1++;
            }
            for (i = num1; i <= num2; i += 2)
            {
                Console.WriteLine(i);
            }


            string filePath = Directory.GetCurrentDirectory();
            Console.WriteLine("Sisestage fail'i nimi (kttekst.txt) : ");
            string fileName = Console.ReadLine();
            string fullPath = filePath + "\\" + fileName;

            int counter = 0;
            int five = 0;

            string[] words = File.ReadAllText(fullPath).Split(' ');
            foreach (string word in words)
            {
                if (word.Length <= 4)
                {
                    five += 1;
                }
                counter += 1;
            }

            Console.WriteLine("Failis " + fileName + " on kokku: {0} sõnu.", counter);
            Console.WriteLine("Nendest {0} on väiksemad kui 5 tähte.",five);

            Console.ReadLine();
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

            double avg1 = nums1.Average();
            double avg2 = nums2.Average();

            double avg3 = (nums1.Sum() + nums2.Sum()) / (nums1.Length + nums2.Length);

            Console.WriteLine("Esimese list'i keskmine on: " + avg1);
            Console.WriteLine("Teise list'i keskmine on: " + avg2);
            Console.WriteLine("Mõlema list'ide keskmine on: " + avg3);

            Console.ReadLine();
        }
    }
}
