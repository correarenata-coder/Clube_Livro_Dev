using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo09.Exemplo._1_Funcionario
{
    public class Funcionario
    {
        public virtual decimal CalcularSalario()
        {
            return 2000;
        }

        public virtual void BaterPonto()
        {

            // Esse que é o problema, a classe base tem um método que não tem implementação, e as classes derivadas são obrigadas a implementar esse método, mesmo que ele não faça sentido para elas. Isso viola o princípio de substituição de Liskov,
            // porque as classes derivadas não podem ser substituídas pela classe base sem alterar o comportamento do programa.
            throw new NotImplementedException();
        }
    }
}
