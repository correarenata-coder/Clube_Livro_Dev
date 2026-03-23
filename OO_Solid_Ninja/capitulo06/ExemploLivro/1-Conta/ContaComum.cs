using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06.ExemploLivro
{
    public class ContaComum
    {
        protected double saldo { get; set; }

        public ContaComum()
        {
            this.saldo = 0;
        }

        public void deposita(double valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor inválido");

            this.saldo += valor;
        }

        public double getSaldo()
        {
            return saldo;
        }

        public void rende()
        {
            this.saldo *= 1.1;
        }
            
    }
}
