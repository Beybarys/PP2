using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static bool pal(string s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[-i - 1 + s.Length]) return false;
            }return true;
        }
        static void Main(string[] args)
        {
            FileStream a = new FileStream(@"C:\Users\Acer\Desktop\Proga\week2\Task1\Writeline.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(a);
            string s = sr.ReadToEnd();
            Console.WriteLine(s);
            if (pal(s)) 
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            sr.Close();
            a.Close();
            Console.ReadKey();
        }
    }
}
