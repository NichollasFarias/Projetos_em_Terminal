using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx01_33328_33574
{
    class Ex01_33328_33574
    {
        static void Main(string[] args)
        {

            int Base, Altura, Area;

            Console.Write("Insira o valor da base: ");
            Base = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor da altura: ");
            Altura = int.Parse(Console.ReadLine());


            Area = Base * Altura;
            Console.Write("Valor da área = {0}", Area);

            Console.ReadKey();

        }
    }
}
