using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx04_33328_33574
{
    class Ex04_33328_33574
    {
        static void Main(string[] args)
        {

            float Base, Altura, Area;

            Console.Write("Digite o valor da base: ");
            Base = float.Parse(Console.ReadLine());

            Console.Write("Digite a altura: ");
            Altura = float.Parse(Console.ReadLine());


            Area = (Base * Altura) / 2;
            Console.Write("Valor da sua area: = {0}", Area);

            Console.ReadKey();



        }
    }
}
