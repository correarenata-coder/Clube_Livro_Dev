using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo05.Refatorando
{
    public class BoletoRef
    {

        public double Valor { get; private set; }
        public IFormaDePagamento EstrategiaPagamento { get; private set; }
        public BoletoRef(double valor, DateTime dataVencimento, IFormaDePagamento estrategia)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor do boleto deve ser maior que zero");

            Valor = valor;
            EstrategiaPagamento = estrategia;
        }
    }
}
