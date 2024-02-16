using System;

namespace TesteErros
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Introduza um numero");
            try
            {
                i = int.Parse(Console.ReadLine());
            }

            catch (FormatException e)
            {
                // Caso não tenha sido inserido um número inteiro
                Console.WriteLine("Error:O número não é do tipo inteiro");
            }
            catch (OverflowException e)
            {
                // Caso tenha sido inserido um número inteiro demasiado grande ou demasiado pequeno
                Console.WriteLine("Error:O número é muito grande");
            }
            catch (Exception e)
            {
                // Ocorreu um erro desconhecido
                Console.WriteLine("Error: Auto destruição ativada");
            }
            finally
            {
                Console.WriteLine("Quem ler esta menssagem é... ");
            }





        }
    }
}
