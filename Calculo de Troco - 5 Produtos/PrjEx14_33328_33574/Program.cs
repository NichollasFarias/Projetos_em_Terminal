using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx14_33328_33574
{
    class Program
    {
        static void Main(string[] args)
        {
            double P1, P2, P3, P4, P5, T, VD, TR;

            Console.Write("Digite o P1:  ");
            P1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o P2:  ");
            P2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o P3:  ");
            P3 = double.Parse(Console.ReadLine());

            Console.Write("Digite o P4:  ");
            P4 = double.Parse(Console.ReadLine());

            Console.Write("Digite o P5:  ");
            P5 = double.Parse(Console.ReadLine());

            T = P1 + P2 + P3 + P4 + P5;
            Console.WriteLine("O Total é: {0}", T);

            Console.Write("Digite o Valor dado:  ");
            VD = double.Parse(Console.ReadLine());

            TR = VD - T;
            Console.Write("Digite o Troco deu: {0} ", TR);

            Console.ReadKey();
        }
    }
}
