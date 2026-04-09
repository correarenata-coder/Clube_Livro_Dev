using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo02.ExemploLivro
{
    public class CalculadoraDeSalario
    {
        // Problema da classe ter vários if de cargos, e cada um ter uma regra diferente de cálculo de salário.
        public decimal Calcula(Funcionario1 funcionario)
        {
            if (funcionario.Cargo == Cargo1.Desenvolvedor)
            {
                return dezOuVintePorCento(funcionario);
            }
            else if (funcionario.Cargo == Cargo1.DBA || funcionario.Cargo == Cargo1.Testador)
            {
                return quinzeOuVintePorCentro(funcionario);
            }
            throw new Exception("Cargo desconhecido");
        }


        private decimal dezOuVintePorCento(Funcionario1 funcionario)
        {
            if (funcionario.Salario > 3000.0M)
            {
                return funcionario.Salario * 0.8M;
            }
            else
            {
                return funcionario.Salario * 0.9M;
            }
        }

        private decimal quinzeOuVintePorCentro(Funcionario1 funcionario)
        {
            if (funcionario.Salario > 4000.0M)
            {
                return funcionario.Salario * 0.8M;
            }
            else
            {
                return funcionario.Salario * 0.9M;
            }
        }
    }
}
