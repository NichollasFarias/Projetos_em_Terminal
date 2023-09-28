using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx13_33328_33574
{
    class Ex13_33328_33574
    {
        static void Main(string[] args)
        {
            double Dolar, Reais;

            Console.Write("Digite quantos Dolars:  ");
            Dolar = double.Parse(Console.ReadLine());

            Reais = Dolar * 3.91;
            Console.WriteLine("Em reais será: {0}", Reais);

            Console.ReadKey();
        }
    }
}
