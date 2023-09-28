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

            double p1, p2;


            try
            {
                Console.Write("Digite a primeira nota: ");
                p1 = double.Parse(Console.ReadLine());


                p2 = (15 - p1) / 2;

                Console.Write("A sua segunda nota devera ser: {0}", p2);
                Console.ReadKey();
          
                
            }

            catch
            {
                Console.Write("Deu ruim, tenta denovo");
                Console.ReadKey();
                return;

            }
        }
    }
}
