using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        struct TestowaStruktura
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("test");
            Console.WriteLine(mnozenie(8));
        }
        static int mnozenie(int zmienna1)
        {
            return zmienna1 * 10;

        }
    }
}
