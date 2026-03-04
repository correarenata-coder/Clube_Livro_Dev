using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo05.Refatorando
{
    public class PagamentoBoleto : IFormaDePagamento
    {
        public MeioDePagamento Meio => MeioDePagamento.Boleto;

        public void Processar(double valor, FaturaRef fatura)
        {
            // Aqui você poderia adicionar lógica de desconto para boleto, por exemplo
            var pagamento = new PagamentoRef(valor, Meio);


            // Esta tudo encapsulado dentro da regra de negócio 
            fatura.adicionaPagamento(pagamento);
            
        }
    }
}
