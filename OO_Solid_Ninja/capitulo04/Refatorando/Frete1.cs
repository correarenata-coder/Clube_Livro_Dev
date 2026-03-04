using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04.Refatorando
{
    public class Frete1 : IServicoDeEntrega
    {
        public double para(string Cidade)
        {
            return 15;
        }
    }
}
