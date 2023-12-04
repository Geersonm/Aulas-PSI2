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

        public void SetRed(int red)
        {
            this.red = red;
        }

        public int GetRed()
        {
            return red;
        }

        public void SetGreen(int green)
        {
            this.green = green;
        }

        public int GetGreen()
        {
            return green;
        }

        public void SetBlue(int blue)
        {
            this.blue = blue;
        }

        public int GetBlue()
        {
            return blue;
        }

        public void SetAlpha(int alpha)
        {
            this.alpha = alpha;
        }

        public int GetAlpha()
        {
            return alpha;
        }

        public int GetGrau()
        {
            return (red + green + blue) / 3;
        }
    }
}
