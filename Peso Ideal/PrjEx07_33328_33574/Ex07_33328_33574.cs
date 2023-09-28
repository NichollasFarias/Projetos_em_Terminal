using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx07_33328_33574
{
    class Ex07_33328_33574
    {
        static void Main(string[] args)
        {
            float Altura, Peso, R;

            try
            {

                Console.Write("Insira a Altura: ");
                Altura = float.Parse(Console.ReadLine());

                Console.Write("Insira o Peso: ");
                Peso = float.Parse(Console.ReadLine());

                R = Peso / (Altura * Altura);

                if (R < 20)
                {
                    Console.Write("Abaixo do Peso, VAI COMER CARALHO!");
                }

                else
                {
                    if (20 <= R && R < 25)
                    {
                        Console.Write("Peso ideal, fica tranquilo parça");
                    }

                    else
                    {
                        if (R >= 25)
                        {
                            Console.Write("Acima de PESO VAI MALHAR O SEU GORDO!!!!");
                        }

                        else
                        {

                        }
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
