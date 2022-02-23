using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Independent_work
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            /*Console.WriteLine("Enter a string of arbitrary length:");
            string str = Console.ReadLine();
            Console.WriteLine("Enter a character to find the percentage of its occurrence in a string:");
            char sum = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int length = str.Length;
            char[] strArr = str.ToCharArray();
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                if (strArr[i] == sum)
                {
                    counter++;
                }
            }
            double Dlength = Convert.ToDouble(length);
            double Dcounter = Convert.ToDouble(counter);
            double percent = (Dcounter / Dlength) * 100;
            Console.WriteLine($"Character occurrence percentage {sum} equals {percent}%");
            Console.ReadLine();*/

            //2
            int[,] mass = new int[10, 10];
            Random random = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = random.Next(1, 20);
                    Console.Write(mass[i, j] + " ");
                }
            }





            Console.ReadLine();
        }
    }
}
