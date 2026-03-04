using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04.ExemploLivro
{
    public class CalculadoraDePrecos
    {
        public double calcula(Compra produto)
        {
            
            Frete correios = new Frete();
            double frete = correios.para(produto.Cidade);
            double desconto = 0;

            //if regra 1
            TabelaDePrecoPadrao tabela = new TabelaDePrecoPadrao();
            desconto = tabela.descontoPara(produto.Valor);

            //if regra 2
            TabelaDePrecoDiferente tabela2 = new TabelaDePrecoDiferente();
             desconto = tabela2.descontoPara(produto.Valor);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
