using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo02.ExemploLivro
{
    public class Funcionario1
    {
        public Cargo1 Cargo { get; set; }
        public decimal Salario { get; set; }
    }

    public enum Cargo1
    {
        Desenvolvedor = 1,
        DBA = 2,
        Testador = 3
    }
}
