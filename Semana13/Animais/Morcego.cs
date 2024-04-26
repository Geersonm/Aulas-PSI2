using System;

namespace Animais
{
    public class Morcego : Animal , IMamifero ,IVoador
    {
        public int nAasas {get {return 2;}}
        public int nMamilos {get{return 2;}}
        public override string Som()
        {
            return "Im Batman!!";
        }
    }
}