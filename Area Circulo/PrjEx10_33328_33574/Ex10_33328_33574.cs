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
            double diametro, PI, raio, area;

            Console.Write("Digite o diâmetro:   ");
            diametro = double.Parse(Console.ReadLine());

            raio = diametro / 2;
            PI = Math.PI;
            area = PI * raio * raio;
            Console.Write("A área é: {0}", area);

            Console.ReadKey();

        }
    }
}
