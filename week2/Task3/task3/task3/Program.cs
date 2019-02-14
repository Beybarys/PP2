using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        static void printInfo(FileSystemInfo dir, int n)
        {
            string s = new string('\t', n);
            s += dir.Name;
            Console.WriteLine(s);
            if (dir.GetType() == typeof(DirectoryInfo))
            {
                var f = (dir as DirectoryInfo).GetFileSystemInfos();
                foreach(var i in f)
                {
                    printInfo(i, n + 1);
                }
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Acer\Desktop\Proga");
            printInfo(dir, 0);
            Console.ReadKey();
        }
    }
}
