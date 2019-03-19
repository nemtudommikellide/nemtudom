using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181113_valtozok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*sring nap;
            Console.Write("kérem a napot! ");
            nap=Console.ReadLine();
            Console.WriteLine("ma " + nap + " van.");
            Console.Write("ma ");
            Console.Write(nap);
            Console.WriteLine(" van.");
            Console.WriteLine("ma {2} van.",nap,"alma",2);
            string nev;
            Console.Write("add meg a neved! ");
            nev = Console.ReadLine();
            Console.WriteLine("{0}nak hívnak", nev);*/
            int szam;
            Console.Write("kérek egy egész számot! ");
            szam = int.Parse(Console.ReadLine());
            Console.WriteLine("A megadott szám a(z) {0}.", szam);
            int szam1;
            Console.Write("Kérek még egy egész számot! ");
            szam1 = Convert.ToInt32(Console.ReadLine());
            int a, b;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a + b);
            

            
            
            Console.WriteLine("Nyomd le az ENTER-t!");
            Console.ReadLine();
        }
    }
}
