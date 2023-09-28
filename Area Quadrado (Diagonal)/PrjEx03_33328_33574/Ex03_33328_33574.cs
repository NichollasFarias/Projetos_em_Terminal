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

            float Area, Diagonal;


            Console.Write("Digite o valor da diagonal: ");
            Diagonal = float.Parse(Console.ReadLine());


            Area = (Diagonal * Diagonal) / 2;
            Console.Write("Valor da sua área: = {0}", Area);

            Console.ReadKey();



        }
    }
}
