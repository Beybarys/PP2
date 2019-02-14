using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; Math.Sqrt(i) <= n; i++) 
            {
                if (n % i == 0)  return false;
            }return true;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Acer\Desktop\Proga\week2\Task2\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadToEnd();
            string[] arr = s.Split();
            int[] vs = new int[arr.Length];
            for(int i=0; i<arr.Length; i++)
            {
                vs[i] = int.Parse(arr[i]);
            }
            FileStream file = new FileStream(@"C:\Users\Acer\Desktop\Proga\week2\Task2\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter a = new StreamWriter(file);
            string sf = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(vs[i]))
                {
                    sf += vs[i] + " ";
                }
            }
            a.Write(sf);
            a.Close();
            file.Close();
            sr.Close();
            fs.Close();
            Console.ReadKey();
        }
    }
}
