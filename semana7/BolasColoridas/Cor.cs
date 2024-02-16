using System;

namespace BolasColoridas
{
    public class Cor
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Cor(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Cor(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 225;
        }

        public int Red
        {
            get
            {
                return red;
            }

            set
            {
                this.red = red;
            }


        }
        public int Green
        {
            get
            {
                return green;
            }
            set
            {
                this.green = green;
            }
        }

        

        public int Blue
        {
            get
            {
                return blue;
            }
            set
            {
                this.blue = blue;
            }
        }

        

        public int Alpha{get; set}
        {
             get
            {
                return alpha;
            }
            set
            {
                this.alpha = alpha;
            }
        }

        public int Grau
        {
            get
            {
                return (red + green + blue) / 3;
            }

        }
    }
}
