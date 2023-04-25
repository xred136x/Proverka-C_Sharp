using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Proverka_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            if (args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                path = Environment.CurrentDirectory;
            }
            try
            {
                path = args[0];
            }
            catch (Exception e00)
            {
                Console.WriteLine(e00.Message);
                path = Environment.CurrentDirectory;
            }
            DirectoryInfo myDirInfo = new DirectoryInfo(path);
            foreach (var item in myDirInfo.GetDirectories())
            {
                Console.WriteLine($"Каталог {item}");
            }
            foreach (var item in myDirInfo.GetFiles())
            {
                Console.WriteLine($"Файл {item}");
               
            }
            Console.ReadKey();
        }
    }
    
}
