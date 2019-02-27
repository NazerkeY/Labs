using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task_1
{
    public class ComplexNumber
    {
        public double a;
        public double b;
        public ComplexNumber()
        {

        }
        public void PrintInfo()
        {
            Console.WriteLine(string.Format("{0} + {1} * i", a, b));
        }
    }
    class Program
    {
        private static void Serialization()
        {
            ComplexNumber cn = new ComplexNumber();
            cn.a = 4.98;
            cn.b = 5;
            cn.PrintInfo();
            FileStream fs = new FileStream("ComplexNumber.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(ComplexNumber));
            xs.Serialize(fs, cn);
            fs.Close();
        } 
        private static void Deserialization()
        {
            FileStream fs = new FileStream("ComplexNumber.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(ComplexNumber));
            ComplexNumber cn = xs.Deserialize(fs) as ComplexNumber;
            cn.PrintInfo();
            fs.Close();
        }
        static void Main(string[] args)
        {
            Deserialization();
        }
    }
}
