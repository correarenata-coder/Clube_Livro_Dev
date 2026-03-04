using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04.Refatorando
{
    public class CalculadoraDePrecos_Ref
    {
        private ITabelaDePreco _tabela;
        private IServicoDeEntrega _servico;
        public CalculadoraDePrecos_Ref(ITabelaDePreco tabela, IServicoDeEntrega servico)
        {
            _tabela = tabela;
            _servico = servico;
        }
        public double calcula(Compra_Ref produto)
        {
            double frete = _servico.para(produto.Cidade);
            double desconto = _tabela.descontopara(produto.Valor);
            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
