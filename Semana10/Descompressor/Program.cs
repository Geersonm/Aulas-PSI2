using System;
using System.IO;
using System.IO.Compression;


namespace Descompressor
{
    class Program
    {
     
      
     static string desktop=Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      static string Filepath=path.Combine(desktop,"file.txt.gz");
      static string filepath2=path.Combine(desktop,"file.txt.gz");

        static void Main(string[] args)
        {
            Console.WriteLine("Escolhe uma  das opções escrevendo o numero conrrespondente:\n1-comprimir ou 2-descomprimir ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Comprime(Filepath);
                    break;
                case 2:
                    Descomprime();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }


        }
        static void Comprime(string s)
        {
            st
            string line;


           using(FileStream fs = new FileStream(Filepath, FileMode.Create, FileAccess.Write)) ;

            using(GZipStream gzs = new GZipStream(fs, CompressionLevel.Optimal));

            using(StreamWriter sw = new StreamWriter(gzs));

            while ((line = Console.ReadLine()).Length != null)
            {
                sw.WriteLine(line);
            }

            sw.Close();

            Console.WriteLine("Arquivo comprimido com sucesso.");
        }

        static void Descomprime()
        {
            string line;

            FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Read);

            GZipStream gzs = new GZipStream(fs, CompressionMode.Decompress);

            StreamReader sw = new StreamReader(gzs);
            StreamWriter sw = new StreamWriter(filepath2);

            while ((line = Console.ReadLine()) != null)
            {
                Console.WriteLine(line);
                sw.WriteLine(line);
            }

            sw.Close();
            sw.Close();



            Console.WriteLine("Arquivo descomprimido com sucesso.");
        }
    }
}
