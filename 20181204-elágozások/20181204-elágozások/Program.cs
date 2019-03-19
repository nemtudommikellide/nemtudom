using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181204_elágozások
{
    class Program
    {
        static void hossz()
        {
            int szo;
            char szam;
            Console.Write("Kérek szót!");
            szo =  Console.ReadLine;
            Console.Write("Kérek egy számot!");
            szam = Convert.ToChar(Console.ReadLine());
            if (szo.lenght < szam)
            {
                Console.WriteLine("rövid");
            }
            else
            {

            }
        }







        static void yasuo()
        {
            string szo;
            char betu;
            Console.Write("kérek egy szót!");
            szo = Console.ReadLine();
            Console.Write("Kérek egy betűt!");
            betu = Convert.ToChar(Console.ReadLine());
            if (szo.Contains(betu))
            {
                Console.WriteLine("A(z) {0} tartalmazza a(z) {1} betűt", szo, betu);
            }
            else
            {
                Console.WriteLine("A(z) nem tartalmazza a(z) {1} betűt", szo, betu);
            }

Console.WriteLine("Nyomd le az ENTER-t!");
            Console.ReadLine();
        }













        static void Karakter()
        {
            char betu;
            Console.Write("kérek egy betűt!");
            betu = char.Parse(Console.ReadLine());
            if (betu == 'b')
            {
                Console.WriteLine("Ez a betű b betű!");
            }
            else
            {
                Console.WriteLine("A(z) {0} nem b betű", betu);
            }


Console.WriteLine("Nyomd le az ENTER-t!");
            Console.ReadLine();
        }







        static void Main(string[] args)
        {
           // Karakter();
            yasuo();












        }

        }
    }

