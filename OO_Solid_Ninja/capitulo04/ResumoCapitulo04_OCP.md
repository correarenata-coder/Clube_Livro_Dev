
# Capitulo 4 - Classes Abertas e o tal do OCP (Open/Closed Principle - Princípio do Aberto/Fechado)


##Introdução
using capitulo04.ExemploLivro;

Afirma que as classes devem estar "abertas para extensão, mas fechadas para modificação". Isso significa que devemos projetar nossas classes de forma que seja possível adicionar novas funcionalidades sem alterar o código existente.


Exemplo do livro:
<pre>
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
</pre>

continua...
<pre>
public class TabelaDePrecoPadrao
    {
       public double descontoPara(double valor)
        {
            if (valor > 5000) return 0.03;
            if (valor > 1000) return 0.05;

            return 0;
        }
    }
</prev>
<pre>
public class Frete
    {
        public double para(string cidade)
        {
            if ("SAO PAULO".Equals(cidade.ToUpper()))
            {
                return 15;
            }
            return 30;
        }
    }
</prev>


## 🔍 Qual é o problema?
Se existir várias regras para o cálculo de desconto e várias regras para o frete.Vamos ver o código com vários ifs.
A idéia é poder ser uma classe "aberta para extensão" e "fechadas para modificaçao".
 Para resolver isso  podemos criar interfaces paa conseguirmos fazer novas implementações com herança.

 <pre>
 public interface ITabelaDePreco
    {
        double descontopara(double valor);
    }
 </pre>

 <pre>
 public class TabelaDePreco1 : ITabelaDePreco
    {
        public double descontopara(double valor)
        {
            return 0.03;
        }
    }

     public class TabelaDePreco2 : ITabelaDePreco
    {
        public double descontopara(double valor)
        {
             return 0.05;
            
        }
  
    }
 </pre>

  <pre>
 public interface IServicoDeEntrega
    {
        double para(string Cidade);
    }
 </pre>

 <pre>
 public class Frete1 : IServicoDeEntrega
    {
        public double para(string Cidade)
        {
            return 15;
        }
    }
 </pre>

 Como fazer a chamada
 <pre>
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
 </pre>



## 📚 Fonte

- [Curso SOLID - Balta](https://www.youtube.com/watch?v=P5eqNeGSXRs&list=PLHlHvK2lnJneX-lsKM27WTjmNqpX_YzHF)
- Livro : Orientação a objetos e SOLID para ninjas -Maurício Aniche 