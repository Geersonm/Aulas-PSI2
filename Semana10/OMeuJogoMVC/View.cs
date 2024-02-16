using System;

namespace OMeuJogoMVC
{
    class View
    {
        public class View ()
        {
            int ni;
            Inimigo[] inimi;
            int d;
            int v;
            int e;

            Console.Write("Introduza o numero de inimigos: ");
            ni = int.Parse(Console.ReadLine());

            inimi = new Inimigo[ni];

            for (int i = 0; i < inimi.Length; i++)
            {
                string nomei;
                Console.Write($"\nIntroduza o nome do inimigo {i + 1}:");
                nomei = Console.ReadLine();

                Inimigo A = new Inimigo(nomei);

                inimi[i] = A;

            }

            Console.WriteLine("\nComeço!\n");

            for (int i = 0; i < inimi.Length; i++)
            {

                Console.WriteLine($"Inimigo {i + 1} \nNome:{inimi[i].GetNome()}");
                Console.WriteLine($"Escudo {inimi[i].GetEscudo()}");
                Console.WriteLine($"Vida {inimi[i].GetVida()}\n");
            }

            for (int i = 0; i < inimi.Length; i++)
            {
                Console.Write($"Dano a infligir no inimigo {i + 1}: ");
                d = int.Parse(Console.ReadLine());
                inimi[i].Danificar(d);
                Console.WriteLine("");

            }

            Console.WriteLine("\nDepois de danificar!\n");


            for (int i = 0; i < inimi.Length; i++)
            {
                if (inimi[i].GetVida() > 0)
                {
                    Console.WriteLine($"Inimigo {i + 1} \nNome:{inimi[i].GetNome()}");
                    Console.WriteLine($"Escudo {inimi[i].GetEscudo()}");
                    Console.WriteLine($"Vida {inimi[i].GetVida()}\n");
                }
                else
                {
                    Console.WriteLine($"Inimigo {i + 1} morto!\n");
                }
            }

            for (int i = 0; i < inimi.Length; i++)
            {
                Console.Write($"Abastecer escudo do {i + 1}: ");
                e = int.Parse(Console.ReadLine());
                inimi[i].Abastecer(Abastecimento.Escudo, e);


                Console.Write($"Abastecer vida do {i + 1}: ");
                v = int.Parse(Console.ReadLine());
                inimi[i].Abastecer(Abastecimento.Vida, v);
                Console.WriteLine("");
            }

            Console.WriteLine("\nDepois de abastecer\n");






            for (int i = 0; i < inimi.Length; i++)
            {
                if (inimi[i].GetVida() > 0)
                {
                    Console.WriteLine($"Inimigo {i + 1} \nNome:{inimi[i].GetNome()}");
                    Console.WriteLine($"Escudo {inimi[i].GetEscudo()}");
                    Console.WriteLine($"Vida {inimi[i].GetVida()}\n");
                }
                else
                {
                    Console.WriteLine($"Inimigo {i + 1} nao pode abastecer, porque está morto!\n");
                }
            }

            Console.WriteLine($"Numero de abastecimentos == {Inimigo.GetNA()}\n")

        }
    }
}
