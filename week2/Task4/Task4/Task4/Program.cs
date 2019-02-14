using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = @"file.txt";
            var c = File.Create(@"C:\Users\Acer\Desktop\Proga\week2\Task4\created\" + s);
            c.Close();
            File.Copy(@"C:\Users\Acer\Desktop\Proga\week2\Task4\created\" + s, @"C:\Users\Acer\Desktop\Proga\week2\Task4\copied\" + s);
            File.Delete(@"C:\Users\Acer\Desktop\Proga\week2\Task4\created\" + s);
        }
    }
}
