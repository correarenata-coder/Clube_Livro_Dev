using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06.Refatorando
{
    public class ContaComum
    {
        private ManipuladorDeSaldo manipulador;

        public ContaComum()
        {
            this.manipulador = new ManipuladorDeSaldo();
        }

        public void saca(double valor)
        {
            this.manipulador.adicionar(valor);
        }


        public void rende()
        {
            this.manipulador.juros(0.1);
        }


    }
}
