using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    {
        public static bool Palindrome(string str)
        {
            bool ans = true;
            for(int i=0; i<str.Length; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    ans = false;
                    break;
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\Users\Acer\Desktop\Solutions\Palindrome.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            string text = sr.ReadToEnd();
            if (Palindrome(text) == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            sr.Close();
            file.Close();
        }
    }
}
