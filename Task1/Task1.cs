using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Алексей/source/repos";
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Нет такой папки");
            }
            else
            {
                string[] drs = Directory.GetDirectories(path);
                string[] fls = Directory.GetFiles(path);
                foreach (string i in drs)
                {
                    Console.WriteLine(i);
                }
                foreach (string i in fls)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
