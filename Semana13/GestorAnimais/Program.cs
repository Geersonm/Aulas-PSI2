using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            string nome;
            List<Animal> LA = new List<Animal>();
            Console.WriteLine("Escreve um nome de um animal a tua escolha: ");
            nome=Console.ReadLine();
            Console.WriteLine("E qual é a pesagem do animal: ");
            p=int.Parse(Console.ReadLine());

            LA.Add(p);
        }

        static void LA(){

        }
    }
}
