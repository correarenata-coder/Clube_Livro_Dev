using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace capitulo05.ExemploLivro
{
    public class Fatura
    {
        private List<Pagamento> _pagamentos = new List<Pagamento>();

        private double _valor;
        private bool _pago;

        public Fatura(double valor)
        {
            _valor = valor;
            _pago = false;
        }

        public double GetValor()
        {
            return _valor;
        }

        public bool IsPago()
        {
            return _pago;
        }

        public void SetPago(bool pago)
        {
            _pago = pago;
        }

        // ERRADO : expõe a lista interna
        public List<Pagamento> GetPagamentos()
        {
            return _pagamentos;
        }

        public double TotalPago()
        {
            return _pagamentos.Sum(p => p.Valor);
        }

    }
}
