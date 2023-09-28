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
            float n1, n2, n3;

            try
            {
                Console.Write("Insira o valor do primeiro número: ");
                n1 = float.Parse(Console.ReadLine());

                Console.Write("Insira o valor do segundo número: ");
                n2 = float.Parse(Console.ReadLine());

                Console.Write("Insira o valor do terceiro número: ");
                n3 = float.Parse(Console.ReadLine());

                if (n1 > n2)
                {
                    if (n1 > n3)
                    {
                        Console.Write("O primeiro número é maior!");
                    }

                    else 
                    {
                        Console.Write("O terceiro número é maior!");
                    }
                }
                else 
                {
                    if (n2 > n3)
                    {
                        Console.Write("O segundo número é maior!");
                    }

                    else
                    {
                        Console.Write("O terceiro número é maior!");
                    }
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
