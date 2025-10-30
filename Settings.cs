using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Settings
    {
        private static readonly string path_to_file;

        static Settings()
        {
            path_to_file = "C:\\Users\\user\\source\\repos\\ConsoleApp\\";
        }

        public static void PathToFile()
        {
            Console.WriteLine($"Путь к файлу конфигурации: " + path_to_file);
        }
    }
}
