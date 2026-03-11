using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06.Refatorando
{
    // Encapsula bem todo o comportamento e ambas as classes apenas a utilizam
    public class ManipuladorDeSaldo
    {
        private double saldo;
     
        public void adicionar(double valor)
        {
            this.saldo += valor;
        }
        public void retira(double valor)
        {
            if (valor > this.saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente");
            }
            this.saldo -= valor;
        }
        public void juros(double taxa)
        {
            
        }

        public double getSaldo(double taxa)
        {
            return 0;
        }
    }
}
