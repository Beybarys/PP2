using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student
    {
        string name;
        int id, year;
        public Student(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public String GetName()
        {
            return name;
        }
        public int GetId()
        {
            return id;
        }
        public void incrementYear(int year)
        {
            year++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}