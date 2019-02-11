using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void PrintInfo(FileSystemInfo fsi, int n)
        {
            string str = new string(' ', n);
            Console.WriteLine(str + fsi.Name);
            if (fsi.GetType() == typeof(DirectoryInfo))
            {
                FileSystemInfo[] array = ((DirectoryInfo)fsi).GetFileSystemInfos();
                for(int i=0; i<array.Length; i++)
                {
                    PrintInfo(array[i], n + 5);
                }
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Acer\Desktop\Solutions");
            PrintInfo(dir, 0);
        }
    }
}
