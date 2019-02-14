using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[,] array = new string[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j || i == j)
                    {
                        array[i, j] = "[*]";
                    }else
                    {
                        array[i, j] = "";
                    }
                }
            }
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }Console.WriteLine();
            }Console.ReadKey();
        }
    }
}
