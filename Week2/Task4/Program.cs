using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\Users\Acer\Desktop\Solutions\path\original.txt", FileMode.CreateNew, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine("Hello world!");
            sw.Close();
            file.Close();
            string fileName = "original.txt";
            string sourcePath = @"C:\Users\Acer\Desktop\Solutions\path";
            string targetPath = @"C: \Users\Acer\Desktop\Solutions\path1";
            //Use Path class to manipulate file and directory paths
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, file.Name);
            File.Copy(sourceFile, destFile, true);
            File.Delete(sourceFile);
            Console.WriteLine("DONE!");
        }
    }
}
