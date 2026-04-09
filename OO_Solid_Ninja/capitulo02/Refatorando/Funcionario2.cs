using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo02.Refatorando
{

    public class Funcionario2
    {
        public Cargo2 Cargo { get; set; }
        public decimal Salario { get; set; }
    }

    public enum Cargo2
    {
        Desenvolvedor = 1,
        DBA = 2,
        Testador = 3
    }
}
