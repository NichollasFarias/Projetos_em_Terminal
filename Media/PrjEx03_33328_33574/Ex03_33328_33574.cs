using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx03_33328_33574
{
    class Ex03_33328_33574
    {
        static void Main(string[] args)
        {
            int Valor01, Valor02, Valor03, Media;

            Console.Write("Insira o primeiro valor: ");
            Valor01 = int.Parse(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            Valor02 = int.Parse(Console.ReadLine());

            Console.Write("Insira o terceiro valor: ");
            Valor03 = int.Parse(Console.ReadLine());

            Media = (Valor01 + Valor02 + Valor03) /3;
            Console.Write("A Média é  = {0}", Media);

            Console.ReadKey();
        }
    }
}
