using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo07.ExemploLivro._1_Imposto
{
    public class ISS : IImposto
    {
        public NotaFiscal geraNota()
        {
            return new NotaFiscal();
        }

        public double imposto(double valorCheio)
        {
            return 0.1 * valorCheio;
        }
    }
}
