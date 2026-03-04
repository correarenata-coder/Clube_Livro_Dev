using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace capitulo05.ExemploLivro
{
    public class ProcessadorDeBoletos
    {
        public void Processa(List<Boleto> boletos, Fatura fatura)
        {
            double total = 0;
            foreach (var boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.Boleto);

                // Violação de encapsulamento
               // A Fatura está expondo sua lista interna
               //Outra classe está manipulando diretamente seu estado interno
                 //A regra de negócio da Fatura fica espalhada
                fatura.GetPagamentos().Add(pagamento);

                total += boleto.Valor;
            }

            if (total >= fatura.GetValor())
            {
                fatura.SetPago(true);
            }
        }
        
    }
}
