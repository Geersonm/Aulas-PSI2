using System;

namespace Animais
{
    public class Abelha : Animal , IVoador
    { 
        public int nAsas{get{return 2;}} 
        public override string Som()
        {
            return "Bzzzzzzzzz tututututu zzzzzzzzzzzzzzzz tututututu zzzzzzz";
        }
    }
}