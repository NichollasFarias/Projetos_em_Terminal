using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx10_33328_33574
{
    class Ex10_33328_33574
    {
        static void Main(string[] args)
        {
            try
            {
                double p, h, imc;
                char s;

                Console.Write("Digite o peso: ");
                p = double.Parse(Console.ReadLine());

                Console.Write("Digite o altura: ");
                h = double.Parse(Console.ReadLine());

                Console.Write("Digite 1 para mulher e 2 para homem: ");
                s = char.Parse(Console.ReadLine());


                imc = p / (h * h);


                if (s == '1')
                {
                    if (imc < 19)
                    {
                        Console.Write("Abaixo do peso");
                        Console.ReadKey();
                    }

                    else
                    {
                        if (imc > 24)
                        {
                            Console.Write("Acima do peso");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.Write("Peso ideal");
                            Console.ReadKey();
                        }
                    }


                }
                else
                {
                    if (s == '2')
                    {
                        if (imc < 20)
                        {
                            Console.Write("Abaixo do peso");
                            Console.ReadKey();
                        }

                        else
                        {
                            if (imc > 25)
                            {
                                Console.Write("Acima do peso");
                                Console.ReadKey();
                            }

                            else
                            {
                                Console.Write("Peso ideal");
                                Console.ReadKey();
                            }
                        }

                    }
                    else
                    {
                        Console.Write("Sexo digitado inválido, tenta de denovo");
                    }
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
