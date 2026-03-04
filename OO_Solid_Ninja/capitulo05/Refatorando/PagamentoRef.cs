using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo05.Refatorando
{
    public class PagamentoRef
    {
        public double Valor { get; private set; }
        public MeioDePagamento MeioDePagamento { get; private set; }
        public DateTime Data { get; private set; }

        public PagamentoRef(double valor, MeioDePagamento meioDePagamento)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor do pagamento deve ser maior que zero");

            Valor = valor;
            MeioDePagamento = meioDePagamento;
            Data = DateTime.Now;
        }
    }

    public enum MeioDePagamento
    {
        Boleto,
        CartaoCredito,
        Pix,
        Transferencia
    }
}
