using System;

namespace Unidades4X
{
    cclass UnidadeMilitar : Unidade
    {
        private int pa;
    private int xp;

    public void Atacar(Unidade)
    {
        if (vida <= 0)
        {
            Console.WriteLine("Vida insuficiente para viver");
        }
        else
        {
            Console.WriteLine($"Dano {pa}");
            Console.WriteLine($"A vida esta a {vida-pa}");
        }
    }

}
}