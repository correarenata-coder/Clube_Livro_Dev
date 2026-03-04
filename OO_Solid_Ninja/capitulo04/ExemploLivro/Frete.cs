using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04.ExemploLivro
{
    public class Frete
    {
        public double para(string cidade)
        {
            if ("SAO PAULO".Equals(cidade.ToUpper()))
            {
                return 15;
            }
            return 30;
        }
    }
}
