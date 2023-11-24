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
                NPCS[i] = defeniratributo(i);
                n[i] = defenirpoder(i);


            }
            for (int p = 0; p < nNpc; p++)
            {
                Console.WriteLine($"\nNPC {p + 1}: atributo - {NPCS[p]}\n       poder - {n[p]}\n");
            }
        }

        static NPCTraits defeniratributo(int a)
        {
            NPCTraits NPCa = 0;
            int atributo = 0;

            do
            {
                Console.WriteLine($"NPC {a+1}:");
                Console.Write("atributo (0-velocidade, 1-foça, 2-afinidade, 3-agilidade): ");
                atributo = int.Parse(Console.ReadLine());
                if (Enum.IsDefined(typeof(NPCTraits), atributo))
                {
                    NPCa = (NPCTraits)atributo;
                }
                else
                {
                    Console.WriteLine("atributo inválido. Por favor, escolha um atributo válido.");


                }
            } while (!Enum.IsDefined(typeof(NPCTraits), atributo));


            return NPCa;

        }

        static NPCpoder defenirpoder(int p)
        {
            NPCpoder N = 0;
            int Poder=0;
            do
            {
                Console.WriteLine($"NPC {p+1}:");
                Console.Write("\nPoder (0-fogo,1-agua, 2-terra, 3-planta, 4-vento, 5-luz, 6-sombra): ");
                 Poder = int.Parse(Console.ReadLine());
                if (Enum.IsDefined(typeof(NPCpoder), Poder))
                {
                    N = (NPCpoder)Poder;
                }
                else
                {
                    Console.WriteLine("poder inválido. Por favor, escolha um poder válida.");
                 
          
                }
            }while(!Enum.IsDefined(typeof(NPCpoder), Poder));


            return N;



        }

    }
}

