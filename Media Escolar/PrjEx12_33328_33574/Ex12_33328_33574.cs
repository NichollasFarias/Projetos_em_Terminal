using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx12_33328_33574
{
    class Ex12_33328_33574
    {
        static void Main(string[] args)
        {
            double p1, p2, m;


            try
            {
                Console.Write("Digite a primeira nota: ");
                p1 = double.Parse(Console.ReadLine());

                Console.Write("Digite a segunda nota: ");
                p2 = double.Parse(Console.ReadLine());

                m = (p1 + (2 * p2) / 3);

                if (m > 5)
                {
                    Console.Write("Suave");
                    Console.ReadKey();
                }

                else
                {
                    Console.Write("Dançou");
                    Console.ReadKey();
                }

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
