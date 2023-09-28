using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEx12_33328_33574
{
    class Ex12_33328_33574
    {
        static void Main(string[] args)
        {
            double VF, VI, A, T, VF1;

            Console.Write("Digite Velocidade Inicial:  ");
            VI = double.Parse(Console.ReadLine());

            Console.Write("Digite a Aceleração:  ");
            A = double.Parse(Console.ReadLine());

            Console.Write("Digite o Tempo:  ");
            T = double.Parse(Console.ReadLine());

            VF1 = VI + A * T;
            VF = VF1 * 3.6;
            Console.WriteLine("A velocidade final é: {0}", VF);

            Console.ReadKey();
        }
    }
}
