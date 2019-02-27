using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task_2
{
    namespace Task_2
    {
        public class Marks
        {
            public int m;
            public string l;

            public Marks(int n)
            {
                m = n;
                l = getLetter(m);

            }

            public static string getLetter(int m)
            {
                string letter = null;
                if (m >= 0 && m <= 49) { letter = "F"; }
                else if (m >= 50 && m <= 54) { letter = "D"; }
                else if (m >= 55 && m <= 59) { letter = "D+"; }
                else if (m >= 60 && m <= 64) { letter = "C-"; }
                else if (m >= 65 && m <= 69) { letter = "C"; }
                else if (m >= 70 && m <= 74) { letter = "C+"; }
                else if (m >= 75 && m <= 79) { letter = "B-"; }
                else if (m >= 80 && m <= 84) { letter = "B"; }
                else if (m >= 85 && m <= 89) { letter = "B+"; }
                else if (m >= 90 && m <= 94) { letter = "A-"; }
                else if (m >= 95 && m <= 100) { letter = "A"; }
                return letter;
            }

            public override string ToString()
            {
                return m + " " + getLetter(m);
            }

            public Marks()
            {

            }

            class Program
            {
                private static void Serialization()
                {
                    Marks mark = new Marks();
                    List<Marks> result = new List<Marks>();
                    Marks m = new Marks(70);
                    Marks m2 = new Marks(87);
                    Marks m3 = new Marks(100);
                    result.Add(m);
                    result.Add(m2);
                    result.Add(m3);
                    FileStream fs = new FileStream("mark.txt", FileMode.Create, FileAccess.Write);
                    XmlSerializer xs = new XmlSerializer(typeof(List<Marks>));
                    xs.Serialize(fs, result); 
                    fs.Close();
                }

                private static void Deserialization()
                {
                    FileStream fs = new FileStream("mark.txt", FileMode.Open, FileAccess.Read);
                    XmlSerializer xs = new XmlSerializer(typeof(List<Marks>));
                    List<Marks> mark = xs.Deserialize(fs) as List<Marks>;
                    fs.Close();
                    foreach (var ans in mark)
                    {
                        Console.WriteLine(ans.ToString());
                    }
                }
                static void Main(string[] args)
                {
                    Deserialization(); 
                }
            }
        }
    }
}