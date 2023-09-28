using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx09_33328_33574
{
    class Ex09_33328_33574
    {
        static void Main(string[] args)
        {
            float F, C, Valor1, Valor2;

            Console.Write("Digite quantos Celsius:  ");
            C = float.Parse(Console.ReadLine());

                Valor1 = 9 * C;
                Valor2 = Valor1 + 160;
                F = Valor2 / 5;
                Console.Write("Em Fahrenheit é: {0} ", F );

            Console.ReadKey();
        }
    }
}
