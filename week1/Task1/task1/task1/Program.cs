using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
            static bool IsPrime(int n)//creates a new bool function
            {
                if (n < 2) return false;//if n=0 or n=1 the function will continue
            for (int i = 2; i * i <= n; i++)//operator that responsible for each index from 2 to root of n
            {
                    if (n % i == 0) { return false; }//if n divides on i the function will continue
            }
                return true;//for the other cases the function will work
            }
            static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine());//enters a line by converting string to integer
                int[] a = new int[n];//new integer array
                string[] s = new string[n];//new string array
                s = Console.ReadLine().Split();//enters an array by splitting spaces from the line
                int count = 0;//an integer to count
                for (int i = 0; i < n; i++)//for each index
                {
                    a[i] = Convert.ToInt32(s[i]);//converts string to integer array
                }
                for (int i = 0; i < n; i++)
                {
                    if (IsPrime(a[i]))//if the function is true or will work 
                    {
                        count++;//counts every prime number
                    }
                }
                Console.WriteLine(count);//shows the number of primes
                for (int i = 0; i < n; i++)
                {
                    if (IsPrime(a[i]))
                    {
                        Console.Write(a[i] + " ");//shows prime numbers
                    }
                }
                Console.ReadKey();
            }
        }
    }