using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06.ExemploLivro
{
    public class Quadrado : Retangulo
    {
        public Quadrado(int x) : base(x, x)
        {
            // O quadrado é um retângulo com lados iguais, mas a classe Quadrado não pode herdar de Retangulo, pois isso violaria o princípio de substituição de Liskov.
            // A classe Quadrado não pode ser substituída por um Retangulo sem alterar o comportamento esperado do programa, pois um quadrado tem restrições adicionais (lados iguais) que um retângulo não tem.
            // Portanto, a herança entre Quadrado e Retangulo não é adequada, e seria melhor modelar o quadrado como uma classe separada ou usar composição em vez de herança.
           

            
        }
        
    }
}
