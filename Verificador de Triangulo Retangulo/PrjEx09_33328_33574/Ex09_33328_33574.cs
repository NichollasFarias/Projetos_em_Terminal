using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx09_33328_33574
{
    class Ex09_33328_33574
    {
        static void Main(string[] args)
        {
            float A, B, C, c1, c2, c3, V1, V2, V3;

            try
            {
                Console.Write("Insira valor de A: ");
                A = float.Parse(Console.ReadLine());
                Console.Write("Insira valor de B: ");
                B = float.Parse(Console.ReadLine());
                Console.Write("Insira valor de C: ");
                C = float.Parse(Console.ReadLine());
   
                V1 = A * A;
                V2 = B * B;
                V3 = C * C;

                c1 = V2 + V3;
                c2 = V1 + V3;
                c3 = V1 + V2;

                if (V1 == c1)
                {
                    if (V2 == c2)
                    {
                        if (V3 == c3)
                        {
                            Console.Write("É um Triangulo Retangulo");
                        }
                        else { Console.Write("Não é um triangulo"); } 
                    }
                       else { Console.Write("Não é um triangulo"); }     
                }

                else { Console.Write("Não é um triangulo"); }

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
