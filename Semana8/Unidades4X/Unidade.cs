using System;

namespace Unidades4X
{
    public abstract class  Unidade
    {
        public int movimento;
        public virtual int vida{set;get;};
        public abstract float valor{set;};

        public Unidade(int movimento, int vida)
        {

        }


        public void Mover()
        {
            Console.WriteLine($"Movimento: {movimento}");
        }
    }
    
    
    }