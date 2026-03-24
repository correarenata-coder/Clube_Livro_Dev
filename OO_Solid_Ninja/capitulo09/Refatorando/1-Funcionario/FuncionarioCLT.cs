using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo09.Refatorando._1_Funcionario
{
    public class FuncionarioCLT : IFuncionario, IPonto
    {
        public void BaterPonto()
        {
            Console.WriteLine("Ponto registrado");
        }

        decimal IFuncionario.CalcularSalario() => 2000;
    }
}
