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
        }
    }
}
