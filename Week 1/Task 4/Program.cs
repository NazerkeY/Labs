using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  //заводим число (из строки в int)
            for (int i = 0; i <= n; i++)                   //слои(0->1; 1->2.1)                                           
            {
                for (int j = 0; j < i; j++) //(0->2.2)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
        }
    }
}
