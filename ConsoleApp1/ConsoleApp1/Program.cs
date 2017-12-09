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
            string fileName = Directory.GetCurrentDirectory();
            StreamReader sr = new StreamReader(fileName);

            int counter = 0;
            int five = 0;
            string delim = " ";
            string[] fields = null;
            string line = null;

            while (!sr.EndOfStream)
            {
                counter += fields.Length;
            }
            Console.WriteLine("Failis " + fileName + " on kokku: {0} sõnu.", counter);

            string path = Path.Combine(Environment.CurrentDirectory, fileName);

            string[] words = File.ReadAllText(path).Split(' ');
            foreach (string word in words)
            {
                if (word.Length <= 4)
                {
                    five += 1;
                }

            }
            Console.WriteLine("Nendest {0} on väiksemad kui 5 tähte.",five);

            Console.ReadLine();
        }
    }
}
