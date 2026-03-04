using capitulo05.ExemploLivro;
using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo05.Refatorando
{
    public class ProcessadorDeBoletos_Ref
    {
        public void Processa(List<Boleto> boletos, FaturaRef fatura)
        {
            double total = 0;
            foreach (var boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.Boleto);

                fatura.adicionaPagamento(pagamento);
            }

           
        }

    }
}
