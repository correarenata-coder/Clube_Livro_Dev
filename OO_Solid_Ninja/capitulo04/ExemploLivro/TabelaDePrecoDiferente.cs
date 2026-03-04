using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04.ExemploLivro
{
    public class TabelaDePrecoDiferente
    {
        public double descontoPara(double valor)
        {
            if (valor > 4000) return 0.03;
            if (valor > 2000) return 0.05;

            return 0;
        }
    }
}
