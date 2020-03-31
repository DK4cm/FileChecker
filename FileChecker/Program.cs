using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string homeDir = AppDomain.CurrentDomain.BaseDirectory;
            string PathIni = Path.Combine(homeDir, "Path.ini");
            string databaseFile = Path.Combine(homeDir, "data.sqlite");
            if (!File.Exists(PathIni)) 
            {
                Console.WriteLine("Path.ini not found...");
                Console.ReadKey();
                return;
            }

        }
    }
}
