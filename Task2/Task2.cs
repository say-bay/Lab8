using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            string path = "01.txt";
            FileInfo fi = new FileInfo(path);
            fi.Create();
            int[] nbrs = new int[10];
            Random random = new Random();
            StreamWriter sw = new StreamWriter(path, true);
            foreach (int i in nbrs)
            {
                nbrs[i] = random.Next(0, 100);
                sw.WriteLine(i);
            }
            sw.Close();
            int[] txt = new int[10];
            StreamReader sr = new StreamReader(path);
            foreach (int i in txt)
            {
                txt[i] = Convert.ToInt32(sr.ReadLine());
            }
            sr.Close();
            int s = 0;
            foreach (int i in txt)
            {
                s = s + txt[i];
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
