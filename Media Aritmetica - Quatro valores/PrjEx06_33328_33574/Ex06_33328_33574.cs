using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx06_33328_33574
{
    class Ex06_33328_33574
    {
        static void Main(string[] args)
        {

            float Valor01, Valor02, Valor03, Valor04, Resultado;

            Console.Write("Digite o primeiro valor: ");
            Valor01 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            Valor02 = float.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            Valor03 = float.Parse(Console.ReadLine());

            Console.Write("Digite o quarto valor: ");
            Valor04 = float.Parse(Console.ReadLine());


            Resultado = (Valor01 + Valor02 + Valor03 + Valor04) / 4;
            Console.Write("Média Aritmédica: = {0}", Resultado);

            Console.ReadKey();

        }
    }
}
