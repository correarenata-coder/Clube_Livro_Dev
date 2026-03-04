using capitulo05.ExemploLivro;
using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo05.Refatorando
{
    public class ProcessadorDeBoletos_Ref
    {
        public void Processa(List<BoletoRef> boletos, FaturaRef fatura)
        {
            double total = 0;
            foreach (var boleto in boletos)
            {
                PagamentoRef pagamento = new PagamentoRef(boleto.Valor, MeioDePagamento.Boleto);


                // Esta tudo encapsulado dentro da regra de negócio da Fat
                fatura.adicionaPagamento(pagamento);
            }

           
        }

    }
}
