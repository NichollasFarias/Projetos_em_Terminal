using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx08_33328_33574
{
    class Ex08_33328_33574
    {
        static void Main(string[] args)
        {
            float A, B, C, v1, v2, v3, V1, V2, V3;

            try
            {
                Console.Write("Insira valor de A: ");
                A = float.Parse(Console.ReadLine());
                Console.Write("Insira valor de B: ");
                B = float.Parse(Console.ReadLine());
                Console.Write("Insira valor de C: ");
                C = float.Parse(Console.ReadLine());

                v1 = B + C;
                v2 = A + C;
                v3 = A + B;

                V1 = B - C;
                V2 = A - C;
                V3 = A - B;

                if (V1 < A && A < v1)
                {
                    if (V2 < B && B < v2)
                    {
                        if (V3 < C && C < v3)
                        {
                            if (A == B)
                            {
                                if (A == C) 
                                { 
                                    Console.Write("É um triangulo Escaleno"); 
                                }

                                else 
                                { 
                                    Console.Write("É um triangulo Isósceles"); 
                                }
                            }

                            else
                            {
                                if (A == C) { Console.Write("É um triangulo Isósceles"); }

                                else { Console.Write("É um triangulo Equilatero"); }
                            }
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
