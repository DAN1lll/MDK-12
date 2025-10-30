using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public static string Division(int a, int b)
        {
            if (b != 0) { 
                return (a / b).ToString();
            }
            else
            {
                return ("Ошибка: деление на 0");
            }
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
    }
}
