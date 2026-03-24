using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo09.Refatorando._1_Funcionario
{
    public class Estagiario2 : IFuncionario
    {
        decimal IFuncionario.CalcularSalario() => 900;
    }
}
