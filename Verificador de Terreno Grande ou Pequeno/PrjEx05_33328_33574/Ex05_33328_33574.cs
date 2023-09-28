using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx05_33328_33574
{
    class Ex05_33328_33574
    {
        static void Main(string[] args)
        {
            float altura, Base, calculo;

            try
            {

                Console.Write("Insira o valor da base: ");
                Base = float.Parse(Console.ReadLine());

                Console.Write("Insira o valor da altura: ");
                altura = float.Parse(Console.ReadLine());

                calculo = (Base * altura);

                if (calculo > 100)
                {
                    Console.Write("QUE TERRENO GIGANTE!");
                }

                else
                {
                    Console.Write("Que terreno pequeno");
                }


            }
            catch
            {
                Console.Write("Você errou meu confederado");
                Console.ReadKey();
                return;
            }

            Console.ReadKey();
        }
    }
}
