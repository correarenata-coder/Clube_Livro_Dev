# Capitulo 2 - A Coesão e o tal do SRP  (Single Responsibility Principle (Princípio da Responsabilidade Única))

##Introdução

Classe coesa é aquela que tem uma única responsabilidade, ou seja, faz apenas uma coisa. O princípio da responsabilidade única (SRP) é um dos princípios SOLID, e ele nos diz que cada classe deve ter apenas uma razão para mudar. Isso significa que cada classe deve ser responsável por uma única parte do sistema, e não deve ter múltiplas responsabilidades.

Exemplo de classe não coesa:
<pre>	
public decimal Calcula(Funcionario funcionario)
        {
            if (funcionario.Cargo == Cargo.Desenvolvedor)
            {
                return dezOuVintePorCento(funcionario);
            }
            else if (funcionario.Cargo == Cargo.DBA || funcionario.Cargo == Cargo.Testador)
            {
                return quinzeOuVintePorCentro(funcionario);
            }
            throw new Exception("Cargo desconhecido");
        }


        private decimal dezOuVintePorCento(Funcionario funcionario)
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

        private decimal quinzeOuVintePorCentro(Funcionario funcionario)
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

</pre>
Problema da classe ter vários if de cargos, e cada um ter uma regra diferente de cálculo de salário.

Como resolver isso? Criando uma classe para cada cargo, e cada classe ter a sua regra de cálculo de salário. Dessa forma, cada classe tem uma única responsabilidade, e o código fica mais organizado e fácil de manter.
<pre>
 public interface IRegraDeCalculo
    {
        decimal calcula(Funcionario2 f);
    }

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

    public class quinzeOuVintePorCentro : IRegraDeCalculo
    {
        public decimal calcula(Funcionario2 f)
        {
            if (f.Salario > 4000.0M)
            {
                return f.Salario * 0.8M;
            }
            else
            {
                return f.Salario * 0.9M;
            }
        }
    }

</pre>