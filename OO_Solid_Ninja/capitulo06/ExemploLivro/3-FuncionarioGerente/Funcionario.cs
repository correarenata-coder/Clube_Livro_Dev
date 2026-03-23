using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06.ExemploLivro
{
    public class Funcionario
    {
        protected double salario;

        public double bonus()
        {
            return this.salario * 0.2;
        }

    }
}
