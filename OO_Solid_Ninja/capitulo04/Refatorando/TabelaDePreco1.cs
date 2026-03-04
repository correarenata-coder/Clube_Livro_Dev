using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04.Refatorando
{
    public class TabelaDePreco1 : ITabelaDePreco
    {
        public double descontopara(double valor)
        {
            return 0.03;
        }
    }
}
