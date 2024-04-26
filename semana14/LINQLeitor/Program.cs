using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    { 
     string livro = "texto.txt";
     string[] linhas =System.IO.File.ReadAllLines(livro);

     int Lm30=
     (from linha in linhas
        where linha.Length >30
        select linha).Count();
        Console.WriteLine("Livro com mais de 30 letras: " + Lm30);

        double media=
        (from linha in linhas
        select linha.Length).Average();
        Console.WriteLine("Media:"+media);

        bool Lm120=
        (from linha in linhas
        where linha.Length>120
        select linha).Any();
        Console.WriteLine("Existem linhas com mais de 120 letras? \n"+Lm120);

        IEnumerable<string>LetrasB=
        from linha in linhas
        where linha.Contains("B")
        select linha.Split(' ')[0];

        foreach(string linha in LetrasB){
            Console.WriteLine(linha);
        }
    }
}