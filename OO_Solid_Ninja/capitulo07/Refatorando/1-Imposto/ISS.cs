using capitulo07.ExemploLivro._1_Imposto;
using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo07.Refatorando._1_Imposto
{
    public class ISS : ICalculandoDeImposto, IGeradorDeNota
    {
        public NotaFiscal geraNota()
        {
            throw new NotImplementedException();
        }

        public double imposto(double valorCheio)
        {
            throw new NotImplementedException();
        }
    }
}
