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

            Console.ReadLine();
        }
    }
}
