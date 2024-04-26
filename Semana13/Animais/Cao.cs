using System;

namespace Animais
{
    public class Cao : Animal , IMamifero
    {
        public int nMamilos {get{return 8;}}
        public override string Som()
        {
            return "Au au";
        }
    }
}