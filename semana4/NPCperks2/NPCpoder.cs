using System;

namespace NPCPerks
{

[Flags]
    public enum NPCpoder
    {
        fogo =0<<1,
        agua=1<<2,
        terra=1<<3,
        planta=1<<4,
        vento=1<<5,
        luz=1<<6,
        sombra=1<<7
        

    }

}