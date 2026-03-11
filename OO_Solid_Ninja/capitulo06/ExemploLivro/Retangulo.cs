using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06.ExemploLivro
{
    public class Retangulo
    {
        private int x;
        private int y;

        public Retangulo(int x , int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return this.x;

        }
        public int getY()
        {
            return this.y;
        }
    }
}
