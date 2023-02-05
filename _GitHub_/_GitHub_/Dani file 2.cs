using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GitHub_
{
    internal class Dani_file_2
    {
        static double Number(double a, double b)
        {
            return a / b;
        }
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Number(a, b));
        }
    }
}
