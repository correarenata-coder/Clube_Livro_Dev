using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06.Refatorando
{
    public class ContaDeEstudante
    {
        private ManipuladorDeSaldo manipulador;

        public ContaDeEstudante()
        {
            this.manipulador = new ManipuladorDeSaldo();
        }

        public void saca(double valor)
        {
            this.manipulador.adicionar(valor);
        }


        // não tem método rende, pois conta de estudante não rende  
    }
}
