using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo07.ExemploLivro._1_Imposto
{
    public interface IImposto
    {
        NotaFiscal geraNota();
        double imposto(double valorCheio);   
    }
}
