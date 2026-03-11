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
           
            foreach (var boleto in boletos)
            {
                PagamentoRef pagamento = new PagamentoRef(boleto.Valor, MeioDePagamento.Boleto);


                boleto.EstrategiaPagamento.Processar(boleto.Valor, fatura);
            }

           
        }

    }
}
