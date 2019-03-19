using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181120
{
    class Program
    {
        static void Main(string[] args)
        {
         /*   Console.SetCursorPosition(55, 10);
            Console.WriteLine("Márk");
            Console.ReadLine();
            string gyumi;
            int a;
            int ft;
            Console.Write("kérem a gyümölcs nevét! ");
            gyumi = Console.ReadLine();
            Console.Write("kérem a gyümölcs mennyiségét! ");
            a = int.Parse(Console.ReadLine());
            Console.Write("kérem a gyümölcs egységárát! ");
            ft = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}-t vettem a piacon.", gyumi);
            Console.WriteLine("A(z) {0}-ból {1} kilót vettem.", gyumi, a);
            Console.WriteLine("A(z) {0}-ból {1} kilót vettem és {2} forintot fizettem érte.", gyumi, a, a * ft);*/

            int a, b;
            Console.Write("kérek egy számot! ");
            a = int.Parse(Console.ReadLine());
            Console.Write("kérem a másik számot! ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} - {1} = {2}", a, b, b - a);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("{0} / {1} = {2}", a, b, b / a);
            Console.WriteLine("{0} a {1}-val való osztási maradéka {2}.",a,b, a%b);
            Console.WriteLine("{0} a {1}-val való osztási maradéka {2}.",b,a, b%a);
            if(a>b)
            {
                Console.WriteLine("{0} nagyobb mint {1}.",a, b );1

            }
            else
            {

                 Console.WriteLine("{0} nagyobb mint {1}.",b, a);
            }


Console.WriteLine("Nyomd le az ENTERT! ");
            Console.ReadLine();


        }

    }
}