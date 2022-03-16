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
            //--1--

            Console.WriteLine("Enter a string of arbitrary length:");
            string str = Console.ReadLine();
            Console.WriteLine("Enter a character to find the percentage of its occurrence in a string:");
            char sum = Console.ReadKey().KeyChar;
            Console.WriteLine();

            char[] tahed = str.ToCharArray();
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (tahed[i] == sum)
                {
                    counter++;
                }
            }
            double protsent = (Convert.ToDouble(counter) / Convert.ToDouble(str.Length)) * 100;
            Console.WriteLine($"Character occurrence percentage {sum} equals  {Math.Round(protsent, 2)}%");

            //--2--

            int[,] M = new int[10, 10];
            Random random = new Random();
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = random.Next(1, 5);
                    Console.Write(M[i, j] + " ");
                }
                Console.WriteLine();
            }
            int max = M[0, 0];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                double pr = 1;
                double sum = 0;
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    pr = pr * M[j, i];
                    sum = sum + M[i, j];
                    if (i == j)
                        if (max < M[i, j])
                            max = M[i, j];
                }
                Console.WriteLine("multiplication " + (i + 1) + " column =" + pr);
                Console.WriteLine("Sum " + (i + 1) + " string=" + sum);
            }
            Console.WriteLine("Max element " + max);
            
            //--3-- NOT READY
            
            /*string[,] inimene = new string[3, 2];
            Console.WriteLine("Write your name,surname and group");
            inimene[1, 1] = Console.ReadLine();
            inimene[1, 1] = Console.ReadLine();
            inimene[1, 1] = Console.ReadLine();
            Console.WriteLine("Period estimate");
            int a = int.Parse(Console.ReadLine());
            int[] M = new int[a];
            Console.WriteLine("Write your grades");*/

            Console.ReadLine();
        }
    }
}
