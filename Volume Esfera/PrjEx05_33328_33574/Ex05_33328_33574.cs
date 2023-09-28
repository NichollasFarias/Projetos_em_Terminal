using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx05_33328_33574
{
    class Ex05_33328_33574
    {
        static void Main(string[] args)
        {
            double diametro, raio, PI, volume;

            Console.Write("Digite o diametro: ");
            diametro = double.Parse(Console.ReadLine());

            raio = diametro / 2;
            Console.WriteLine("O raio é: = {0}", raio);

            PI = Math.PI;

            volume = 4 * PI * raio * raio * raio / 3;
            Console.WriteLine("O volume é: = {0}", volume);

            Console.ReadKey();


        }
    }
}
