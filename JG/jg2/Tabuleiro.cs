using System;

namespace jg2{
public class  Tabuleiro
{
    public char [,] Casas{get;private set;}

    public Tabuleiro()
    {
        Casas = new char[3,3];
        ReiniciarTabuleiro();
    }
    
    public void ReiniciarTabuleiro()
    {
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Casas[i,j]=' ';
            }
        }
    }
}
}