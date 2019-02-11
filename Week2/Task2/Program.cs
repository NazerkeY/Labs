using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static bool Prime(int n)
        {
            bool ok = true;
            if (n == 1)
            {
                ok = false;
            }
            if (n == 2)
            {
                ok = true;
            }
            else
            {
                for (int i = 2; i < n; i++) { 
                    if (n % i == 0)
                    {
                        ok = false;
                        break;
                    }
            }
        }
        return ok;
        }
        static bool Prime(string s)
        {
            return Prime(int.Parse(s));
        }
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            FileStream file = new FileStream(@"C:\Users\Acer\Desktop\Solutions\Prime.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            string line = sr.ReadLine();
            string[] nums = line.Split();
            foreach (var a in nums)
            {
                if (Prime(a))
                {
                    result.Add(a);
                }
            }
            sr.Close();
            file.Close();
        }
    }
}
