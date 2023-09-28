using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PjEx03_33328_33574
{
    class Ex03_33328_33574
    {
        static void Main(string[] args)
        {
            float n1, n2;

            try
            {

                Console.Write("Insira o valor do primeiro número: ");
                n1 = float.Parse(Console.ReadLine());

                Console.Write("Insira o valor do segundo número: ");
                n2 = float.Parse(Console.ReadLine());

                if (n1 > n2)
                {
                    Console.Write("O primeiro número é maior!");
                    Console.ReadKey();
                }
                else
                {
                    if (n2 > n1)
                    {
                        Console.Write("O segundo número é maior!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("ELES SÃO IGUAIS!");
                        Console.ReadKey();
                    }
                }
            }
            catch
            {
                Console.Write("Você errou meu confederado");
                Console.ReadKey();
                return;
            }
        }
    }
}
