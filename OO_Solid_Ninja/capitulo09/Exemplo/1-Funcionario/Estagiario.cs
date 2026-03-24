using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo09.Exemplo._1_Funcionario
{
    public class Estagiario : Funcionario
    {
        public override decimal CalcularSalario()
        {
            return 1000;
        }
        public override void BaterPonto()
        {
            Console.WriteLine("Ponto registrado para estagiário");
        }
    }
}
