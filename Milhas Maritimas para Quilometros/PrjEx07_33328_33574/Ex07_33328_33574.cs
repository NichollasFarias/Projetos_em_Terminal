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
            double mmar, metros, km;

            Console.Write("Digite a milha maritima:  ");
            mmar = double.Parse(Console.ReadLine());

            metros = mmar * 1852;

            km = metros / 1000;
            Console.Write("A milha maritima em km é igual a: {0}", km);

            Console.ReadKey();




        }
    }
}
