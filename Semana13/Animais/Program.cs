using System;

namespace Animais
{
    public interface IMamifero
    {
        int nMamilos { get; }
    }
    public interface IVoador
    {
        int nAsas { get; }
    
    }
/*
Criar array com 10 animais aleatórios e apresentar, para cada um deles:
○ A frase devolvida pelo método Som()
○ Caso seja mamífero, o número de mamilos
○ Caso seja voador, o número de asas*/
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Animal[] aa;
            aa = new Animal[9];

            for(int i =0; i<10;i++){
                 
            }
        }

        static Animal IdentificarA(int a){
            if(a == 1){
                return new Gato();
        }
    }
    }}
