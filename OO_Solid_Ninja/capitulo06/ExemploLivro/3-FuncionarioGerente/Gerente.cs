using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06.ExemploLivro
{
    public class Gerente: Funcionario
    {
        public double bonus()
        {
            return base.bonus() + this.salario * 0.1;
        }
    }
}
