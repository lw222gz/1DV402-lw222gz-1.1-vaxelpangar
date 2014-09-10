using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint total;
            double subtotal = 371.38;
            double avrundning;

            //subtotal = 
            total = (uint)Math.Round(subtotal);
            avrundning = total - subtotal;

            Console.WriteLine("{0:c}", avrundning);


        }
    }
}
