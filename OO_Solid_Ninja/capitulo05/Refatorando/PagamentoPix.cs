using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo05.Refatorando
{
    public class PagamentoPix : IFormaDePagamento
    {
        public MeioDePagamento Meio => MeioDePagamento.Pix;

        public void Processar(double valor, FaturaRef fatura)
        {
            // Aplicando 5% de desconto
            double valorComDesconto = valor * 0.95;
            var pagamento = new PagamentoRef(valorComDesconto, Meio);


            // Esta tudo encapsulado dentro da regra de negócio 
            fatura.adicionaPagamento(pagamento);
        }
    }
}
