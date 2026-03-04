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
            // Pix confirma na hora, talvez gere um log diferente
            var pagamento = new PagamentoRef(valor, Meio);


            // Esta tudo encapsulado dentro da regra de negócio 
            fatura.adicionaPagamento(pagamento);
        }
    }
}
