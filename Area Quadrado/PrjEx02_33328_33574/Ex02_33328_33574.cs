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

            int Area, Aresta;


            Console.Write("Digite o valor da sua aresta: ");
            Aresta = int.Parse(Console.ReadLine());

            Area = Aresta * Aresta;
            Console.Write("Valor da área: = {0}",Area );

            Console.ReadKey();


        }
    }
}
