using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        public static bool Prime(int num)   //making the method for cheking if the number is prime
        {
            bool ok = true;   //making the parameter which is true at the beginning
            if (num == 1)      // checking one of the case
            {
                ok = false;       
            }
            if (num == 2)
            {
                ok = true;
            }
            else
            {
                for (int i = 2; i < num; i++)  //consider the divisors of the number
                {
                    if (num % i == 0)
                    {
                        ok = false;    //if the number has dividers, then it's false;
                                       //but we need the numbers without dividers, so we break the program
                        break;
                    }
                }
            }
            return ok;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());   //creating and writing new variable(from string to int) (length of array)
            string s = Console.ReadLine();       //writing the numbers to string
            string[] array = s.Split();     //creating a new array and divide the numbers by parts
            int cnt = 0;   //making a new variable
            for (int i = 0; i < n; i++)  //considering all elements in array
            {
                int num = int.Parse(array[i]); //remaking the number from array to the int form
                if (Prime(num) == true)  //check the method 
                {
                    cnt++;  //count the elements which are prime
                }
            }
            Console.WriteLine(cnt);  //Show the number of primes on console
            for (int i = 0; i < n; i++)  //repeat the operation to show all primes
            {
                int num = int.Parse(array[i]);
                if (Prime(num) == true)
                {
                    Console.Write(num + " "); //show the prime numbers
                }
            }
        }
    }
}

