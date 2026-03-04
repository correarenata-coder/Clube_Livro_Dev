using capitulo05.ExemploLivro;
using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo05.Refatorando
{
    public class FaturaRef
    {
        private readonly List<PagamentoRef> _pagamentos = new();

        public double Valor { get; private set; }
        public bool Pago { get; private set; }

        // Só leitura para o mundo externo
        public IReadOnlyCollection<PagamentoRef> Pagamentos => _pagamentos.AsReadOnly();

        public FaturaRef(double valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor da fatura deve ser maior que zero");
      
            Valor = valor;
            Pago = false;
        }

        public void adicionaPagamento(PagamentoRef pagamento)
        {
            if (pagamento == null)
                throw new ArgumentNullException(nameof(pagamento));

            if (Pago)
                throw new InvalidOperationException("Fatura já está paga");

            _pagamentos.Add(pagamento);

            if (TotalPago() >= Valor)
                Pago = true;
        }

        public double TotalPago()
        {
            return _pagamentos.Sum(p => p.Valor);
        }

        public double SaldoRestante()
        {
            return Valor - TotalPago();
        }
    }
}
