using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06.ExemploLivro
{
    public class ContaDeEstudante :ContaComum
    {
        // Conta estudante não rende , por isso não é indicado a Herança

        // Classes filhas precisam respeitar os contratos definidos pela classe pai
        // Classes derivadas devem manter o comportamento esperado da classe base
        public void rende()
        {
            throw new InvalidOperationException("Conta de estudante não rende");
        }
        
    }
}
