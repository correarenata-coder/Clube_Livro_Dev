using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo05.Refatorando
{
    public interface IFormaDePagamento
    {
        MeioDePagamento Meio { get; }
        void Processar(double valor, FaturaRef fatura);
    }
}
