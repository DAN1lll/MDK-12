using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class ProgrammConfig
    {
        private const string version = "1.0.0.1";
        private const string dev_name = "Nazarov Daniil";

        public static void ProgrInfo()
        {
            Console.WriteLine($"Версия программы: {version}\nРазработчик: {dev_name}");
        }
    }
}
