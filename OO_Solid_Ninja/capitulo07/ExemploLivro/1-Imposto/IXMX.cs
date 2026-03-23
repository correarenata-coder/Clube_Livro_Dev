using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo07.ExemploLivro._1_Imposto
{
    public class IXMX : IImposto
    {
        //lança uma exceção,pois o imposto não gera uma nota fiscal
        //isso não é uma boa idéia, pois muda o contrato da classe, o que pode causar problemas para quem a utiliza
        public NotaFiscal geraNota()
        {
            throw new Exception();
        }

        public double imposto(double valorCheio)
        {
           return 0.2 * valorCheio;
        }
    }
}
