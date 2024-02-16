using System;

namespace OMeuJogo
   public class Inimigo
    {
        private string nome;
        private int vida;
        private int escudo;
        private static int na;
        public Inimigo(string nome)
        {
            this.nome = nome;
            vida = 100;
            escudo = 100;
            
        }

        static Inimigo()
        {
            na=0;
        }

        public string GetNome()
        {
            return nome;
        }



        public void Danificar(int dano)
        {
            int sobrou = 0;

            if (vida>0)
            {
                if (escudo > 0)
                {
                    escudo -= dano;
                }
                if (vida > 0 && escudo < 0)
                {
                    sobrou = escudo;
                    vida += sobrou;
                }
                if (vida < 0)
                {

                    vida = 0;

                }

                if (escudo < 0) escudo = 0;
            }
            else
            {
                vida = 0;
                escudo = 0;

            }


        }


        public int GetVida()
        {
            // if (vida <= 50) vida = 50;
            return vida;
        }

        public int GetEscudo()
        {
            return escudo;
        }

        public void SetNome(string novonome)
        {

            string trimnome = novonome.Trim();
            this.nome = trimnome;

        }

        public void Abastecer(Abastecimento ini, int c)
        {

            if (vida>0)
            {
                if (ini == Abastecimento.Vida) vida += c;
                if (vida > 100) vida = 100;
                if (ini == Abastecimento.Escudo) escudo += c;
                if (escudo > 100) escudo = 100;

                na++;
            
            }
        }


        public static int GetNA()
        {
            return na;
        }


    }