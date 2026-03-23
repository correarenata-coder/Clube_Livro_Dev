using capitulo07.ExemploLivro._1_Imposto;
using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo07.Refatorando
{
    public interface IGeradorDeNota
    {
        NotaFiscal geraNota();
    }
}
