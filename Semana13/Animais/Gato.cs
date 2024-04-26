using System;

namespace Animais
{
    public class Gato : Animal , IMamifero
    {
        public int nMamilos {get{return 8;} }
        public override string Som()
        {
            return "Miau miau ... mimimimiau";
        }
    }

}