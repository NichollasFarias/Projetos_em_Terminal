using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listexemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Lista = new List<string>();

            string op = "1", nome;
            while (op == "1")
            {
                Console.Write("Lista do Feira\n\n");
                Console.Write("Digite o item: ");
                nome = Console.ReadLine();

                Lista.Add(nome);
                Console.Clear();
                Console.Write("Deseja colocar mais algum coisa?\n1- Sim\n2- Não");
                op = Console.ReadLine();
                Console.Clear();
            }

            
            Lista.Sort();
            Console.WriteLine("A lista tem " + Lista.Count + " itens!");
            

            Lista.ForEach(i => Console.WriteLine(i));
            Console.ReadKey();
        }
    }
}
