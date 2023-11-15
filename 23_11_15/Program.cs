using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _23_11_15
{
    class Program
    {
        static void Main(string[] args)
        {

            NegyszogClass negysz = new NegyszogClass(3,5);
            negysz.SetKerulet();
            negysz.SetTerulet();


            Console.WriteLine("A négyszög kerülete: {0:0.00}, területe {1:0.00}", negysz.getKerulet(), negysz.getTerulet());

            Console.ReadKey();

        }
    }
}
