using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();     // создаем новую строку
            string line2 = Console.ReadLine();     // создаем вторую строку
            int n = int.Parse(line1);           // новое число, которое заведено в первую строку (string->int)
            string[] nums = line2.Split();     // массив в котором добавлены все элементы(поделены через  пробел)
            for(int i=0;i<nums.Length; i++)   // пробегаемся по элемнтам массива
            {
                int x = int.Parse(nums[i]);    // задаем число и превращаем его в int (элемент массива)
            for(int j=0; j<2; j++)             // повторяем два раза
            {
                Console.Write(x + " ");         //выводим столько сколько требуется в for
            }
            }
        }
    }
}
