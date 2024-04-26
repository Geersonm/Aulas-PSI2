using System;
using System.IO;

namespace jg2
{
    class Program
{
    static void Main(string[] args)
    {
        bool r=true;

        while(r=true){

        
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Jogar");
            Console.WriteLine("2. Estatísticas");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    JogoController jogoController = new JogoController();
                    jogoController.IniciarJogo();
                    break;
                case "2":
                    JogoView me=new JogoView();
                    me.MostrarEstats();
                    me.CarregarEstatisticas();
                    break;
                case "3":
                    Environment.Exit(0);
                    r=false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}

}
