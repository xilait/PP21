using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a3 = 1;
            int b = 1;
            Console.WriteLine("Введи выбор");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    a3 = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    b = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine(a3 + b);
                    break;
                case 4:
                    Console.WriteLine(a3 - b);
                    break;
                case 5:
                    Console.WriteLine(a3 * b);
                    break;
                case 6:
                    Console.WriteLine(a3 / b);
                    break;
            }
        }
    }
}
