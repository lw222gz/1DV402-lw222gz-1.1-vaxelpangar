using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            // variabler
            double belopp = 0;
            double avrundning;
            uint avrundatbelopp;
            uint summa = 0;
            uint tillbaka;


            // belopp

            bool looptest = false;

            do
            {
                try
                {
                    Console.Write("Ange belopp:");
                    belopp = double.Parse(Console.ReadLine());
                    looptest = false;


                    if (belopp < 1)
                    {
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Belopp för litet. Köpet kan inte genomföras.");
                        Console.ResetColor();
                        looptest = true;
                    }
                }
                catch
                {
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Givet belopp felaktigt.");
                    Console.ResetColor();
                    looptest = true;

                }
            } while (looptest == true);


            // Given summa

            bool looptest1 = false;
            do
            {
                try
                {

                    Console.Write("Ange given summa:");
                    summa = uint.Parse(Console.ReadLine());
                    looptest1 = false;

                    if (belopp > summa)
                    {
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("FEL! Given summa är för liten.");
                        Console.ResetColor();
                        looptest1 = true;
                    }
                }

                catch
                {



                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Givet belopp felaktigt.");
                    Console.ResetColor();
                    looptest1 = true;
                }
            } while (looptest1 == true);



            // Uträckingar utav kvarvarande variabler

            avrundatbelopp = (uint)Math.Round(belopp);
            avrundning = avrundatbelopp - belopp;
            tillbaka = summa - avrundatbelopp;


            // Kvitto
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Kvitto");
            Console.Write("----------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Totalt               :   {0:c}", belopp);
            Console.WriteLine("Öresavrundning       :   {0:c}", avrundning);
            Console.WriteLine("Att betala           :   {0:c}", avrundatbelopp);
            Console.WriteLine("Kontant              :   {0:c}", summa);
            Console.WriteLine("Tillbaka             :   {0:c}", tillbaka);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("----------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            if (tillbaka / 500 > 0)
            {
                Console.WriteLine("500 lappar       : {0}st", (int)tillbaka / 500);
                tillbaka %= 500;
            }
            if (tillbaka / 100 > 0)
            {
                Console.WriteLine("100 lappar       : {0}st", (int)tillbaka / 100);
                tillbaka %= 100;
            }
            if (tillbaka / 50 > 0)
            {
                Console.WriteLine("50 lappar        : {0}st", (int)tillbaka / 50);
                tillbaka %= 50;
            }
            if (tillbaka / 20 > 0)
            {
                Console.WriteLine("20 lappar        : {0}st", (int)tillbaka / 20);
                tillbaka %= 20;
            }
            if (tillbaka / 10 > 0)
            {
                Console.WriteLine("10 kroner        : {0}st", (int)tillbaka / 10);
                tillbaka %= 10;
            }
            if (tillbaka / 5 > 0)
            {
                Console.WriteLine("5 kroner         : {0}st", (int)tillbaka / 5);
                tillbaka %= 5;
            }
            if (tillbaka / 1 > 0)
            {
                Console.WriteLine("1 kroner         : {0}st", (int)tillbaka / 1);
            }
            }

    }
}
