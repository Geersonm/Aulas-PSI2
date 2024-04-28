using System;
using System.Collections.Generic;

namespace GestorAnimais
{
    public class Animal : IComparable<Animal>
    {
        public string Nome{get;}

        public int CompareTo(Animal other)
        {
            if(other == null) return 1;
            
            return other.Peso - this.Peso;
        }

        public int Peso{get; set;}

        public Animal(string a, int b)
        {
            Nome = a;
            Peso = b;
        }

        public override string ToString()
        {
            return Nome;
        }   

    }
}