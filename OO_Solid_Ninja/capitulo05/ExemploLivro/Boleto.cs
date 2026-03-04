using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo05.ExemploLivro
{
    public class Boleto
    {

        public double Valor { get; private set; }
        public Boleto(double valor, DateTime dataVencimento)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor do boleto deve ser maior que zero");

            Valor = valor;
           
        }
    }
}
