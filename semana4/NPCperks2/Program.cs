using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            string npc;
            int nNpc;
            NPCTraits[] NPCS;
            NPCpoder[] n;

            Console.Write("\nIntroduza o numero de npc's: ");
            npc = Console.ReadLine();
            nNpc = int.Parse(npc);

            NPCS = new NPCTraits[nNpc];
            n = new NPCpoder[nNpc];

            Console.WriteLine("insira o lhe é pedido");

            for (int i = 0; i < nNpc; i++)
            {
                Console.WriteLine($"NPC {i + 1}:");
                Console.Write("atributo (0-velocidade, 1-foça, 2-afinidade, 3-agilidade): ");
                int atributo = int.Parse(Console.ReadLine());
                if (Enum.IsDefined(typeof(NPCTraits), atributo))
                {
                    NPCS[i] = (NPCTraits)atributo;
                }
                else
                {
                    Console.WriteLine("atributo inválido. Por favor, escolha um atributo válido.");
                    i--;
                    continue;
                }

                Console.Write("\nPoder (0-fogo,1-agua, 2-terra, 3-planta, 4-vento, 5-luz, 6-sombra): ");
                int Poder = int.Parse(Console.ReadLine());
                if (Enum.IsDefined(typeof(NPCpoder), Poder))
                {
                    n[i] = (NPCpoder)Poder;
                }
                else
                {
                    Console.WriteLine("poder inválido. Por favor, escolha um poder válida.");
                    i--;
                    continue;
                }
            }
            for (int p = 0; p < nNpc; p++)
            {
                Console.WriteLine($"\nNPC {p + 1}: atributo - {NPCS[p]}\n       poder - {n[p]}\n");
            }
        }

    }


}


