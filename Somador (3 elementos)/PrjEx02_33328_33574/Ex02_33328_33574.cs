using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx02_33328_33574
{
    class Ex02_33328_33574
    {
        static void Main(string[] args)
        {
            int Valor01, Valor02, Valor03, Soma;

            Console.Write("Insira o primeiro valor: ");
            Valor01 = int.Parse(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            Valor02 = int.Parse(Console.ReadLine());

            Console.Write("Insira o terceiro valor: ");
            Valor03 = int.Parse(Console.ReadLine());

            Soma = Valor01 + Valor02 + Valor03;
            Console.Write("Resultado = {0}", Soma);

            Console.ReadKey();

        }
    }
}
