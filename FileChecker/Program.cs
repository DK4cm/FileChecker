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

            Console.WriteLine("Input the Option:");
            Console.WriteLine("1. Get the checksum to database(from Path.ini)");
            Console.WriteLine("2. Check the local file checkdum");
            string input = Console.ReadLine();
            int option;
            if (!int.TryParse(input, out option))
            {
                Console.WriteLine("Wrong Opton, Exits...");
                Console.ReadKey();
                return;
            }
            switch (option) 
            {
                case 1: //get checksum
                    break;
                case 2: //check ckecksum
                    break;
                default:
                    Console.WriteLine("Wrong Opton, Exits...");
                    Console.ReadKey();
                    return;
            }
        }
    }
}
