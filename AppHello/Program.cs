using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int c = Calc.Sum(4, 10);
            Console.WriteLine(c);
        }
    }
}
