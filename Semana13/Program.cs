using System;
using System.Collections.Generic;

namespace GestorAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animais = new List<Animal>();
            string nome = "";
            string b, pesominimostring;
            int peso, pesominimoint;

            animais.Insert(0, new Animal("Macaco", 50));
            animais.Insert(1, new Animal("Gorila", 100));
            animais.Sort();



            do{
                
                Console.WriteLine("Gestor de Animais: ");
                Console.WriteLine("");
                Console.WriteLine("Opção A: Inserir animal.");
                Console.WriteLine("Opção B: Mostrar animais.");
                Console.WriteLine("Opção C: Mostrar animais com peso minimo.");
                Console.WriteLine("Opção D: Sair.");
                Console.WriteLine("");


                Console.WriteLine("Escolha uma das opções.");
                nome = Console.ReadLine();

                if(nome == "A")
                {
                    Console.WriteLine("Insira o nome do animal.");

                    nome = Console.ReadLine();

                    Console.WriteLine("Insira o peso do animal.");

                    b = Console.ReadLine();

                    peso = Convert.ToInt32(b);

                    Animal ab = new Animal(nome , peso);
                
                    animais.Add(ab);

                    animais.Sort();

                }else if(nome == "B")
                {
                    foreach(Animal ax in animais)
                        {
                            Console.WriteLine($"Nome do animal: {ax}");
                            Console.WriteLine($"Peso do animal: {ax.Peso}");
                            Console.WriteLine("");
                        }

                }else if(nome == "C")
                {                        
                    Console.WriteLine("Qual o peso minimo?");
                    pesominimostring = Console.ReadLine();
                    pesominimoint = Convert.ToInt32(pesominimostring);

                    IEnumerable<Animal> listaanimaiscompesomaiorque = GetAnimaisComPesoMaiorQue(animais, pesominimoint);

                    foreach(Animal ax in listaanimaiscompesomaiorque)
                        {
                            Console.WriteLine($"Nome do animal: {ax}");
                            Console.WriteLine($"Peso do animal: {ax.Peso}");
                            Console.WriteLine("");
                        }
                        
                }else if(nome == "D")
                {
                    System.Environment.Exit(1);
                }
                
            }while(nome != "Sair");
            
            
        }

        public static IEnumerable<Animal> GetAnimaisComPesoMaiorQue(List<Animal> a, int pesominimoint)
        {

            foreach(Animal l in a)
            {
                if(l.Peso > pesominimoint)
                {
                    yield return l;
                }
            }            
            
        }
    }
}
