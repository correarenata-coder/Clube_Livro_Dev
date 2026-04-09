using capitulo02.ExemploLivro;
using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo02.Refatorando
{
    public class dezOuVintePorCento : IRegraDeCalculo
    {

        public decimal calcula(Funcionario2 f)
        {
            if (f.Salario > 3000.0M)
            {
                return f.Salario * 0.8M;
            }
            else
            {
                return f.Salario * 0.9M;
            }
        }
    }
}
