using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx11_33328_33574
{
    class Ex11_33328_33574
    {
        static void Main(string[] args)
        {
            double Diametro, PI, Raio, Volume, Altura;

            Console.Write("Digite o diametro:  ");
            Diametro = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura:  ");
            Altura = double.Parse(Console.ReadLine());

            Raio = Diametro / 2;

            PI = Math.PI;

            Volume = (PI * Raio * Raio * Altura) / 3;
            Console.WriteLine("O volume é: {0}", Volume);

            Console.ReadKey();
        }
    }
}
