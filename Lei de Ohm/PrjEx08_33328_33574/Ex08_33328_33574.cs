using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx08_33328_33574
{
    class Ex08_33328_33574
    {
        static void Main(string[] args)
        {
            double Volts, Amperes, Ohs;

            Console.Write("Digite a resistencia:  ");
            Ohs = double.Parse(Console.ReadLine());

            Console.Write("Digite quantos Amperes:  ");
            Amperes = double.Parse(Console.ReadLine());

            Volts = Ohs * Amperes;
            Console.Write("A voltagem é equivalente a: {0}", Volts);

                    Console.ReadKey();

        }
    }
}
