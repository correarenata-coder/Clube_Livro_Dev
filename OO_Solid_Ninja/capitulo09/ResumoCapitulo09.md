# Capitulo 9 - Maus cheiros em design

## Introdução
Nesse capitulo será explorado o conjunto de "más práticas" de design, ou seja, os "code smells". Esses "cheiros de código" são indicadores de que algo pode estar errado no design do código, e podem ser usados para identificar áreas que precisam de refatoração. Vamos explorar alguns desses "code smells":


## 1 - Refused Bequest

O "Refused Bequest" ocorre quando uma classe filha não utiliza ou não precisa de todos os métodos ou propriedades herdados da classe pai. Isso pode indicar que a hierarquia de classes não está bem estruturada, e que a classe filha está sendo forçada a herdar algo que não é relevante para ela. Para resolver esse problema, é importante revisar a hierarquia de classes e garantir que cada classe tenha uma única responsabilidade, seguindo o princípio da responsabilidade única (SRP).

Forma ruim em c# :
<pre>
class Funcionario
{
    public virtual decimal CalcularSalario()
    {
        return 2000;
    }

    public virtual void BaterPonto()
    {
        Console.WriteLine("Ponto registrado");
    }
}


class Estagiario : Funcionario
{
    public override decimal CalcularSalario()
    {
        return 1000;
    }

    public override void BaterPonto()
    {
        throw new NotImplementedException(); // 🚨 cheiro ruim
    }
}
</pre>

Funcionário bate o ponto, mas o estagiário não precisa bater o ponto, então ele lança uma exceção. Isso é um sinal de que a hierarquia de classes não está bem estruturada, e que a classe Estagiário está sendo forçada a herdar algo que não é relevante para ela. Para resolver esse problema, seria melhor criar uma hierarquia de classes diferente, onde o Estagiário não herda do Funcionario, ou seja, criar uma interface ou classe abstrata que defina apenas os métodos relevantes para cada tipo de funcionário.

## 🔍 Como podemos identificar?

Se você ver algo assim:

* `throw new NotImplementedException()`
* método vazio
* `override` que não faz sentido

👉 🚨 **ALERTA: possível *Refused Bequest***


Forma Correta:
<pre>
interface IFuncionario
{
    decimal CalcularSalario();
}

interface IPonto
{
    void BaterPonto();
}

class FuncionarioCLT : IFuncionario, IPonto
{
    public decimal CalcularSalario() => 2000;
    public void BaterPonto() => Console.WriteLine("Ponto registrado");
}

class Estagiario : IFuncionario
{
    public decimal CalcularSalario() => 1000;
}
</pre>


## 2 - Feature Envy
Quando um método usa mais dados de outra classe do que da própria classe

<pre>
class Cliente
{
    public string Tipo { get; set; }
    public decimal TotalCompras { get; set; }
}
class DescontoService
{
    public decimal CalcularDesconto(Cliente cliente)
    {
        if (cliente.Tipo == "VIP" && cliente.TotalCompras > 1000)
        {
            return 0.2m;
        }

        return 0;
    }
}


</pre>

🚨 Problema

👉 O método CalcularDesconto:

usa dados do Cliente
não usa quase nada de si mesmo

💥 Ele está “mais interessado” no Cliente do que na própria classe

👉 Isso é Feature Envy

Forma Correta:
<pre>
class Cliente
{
    public string Tipo { get; set; }
    public decimal TotalCompras { get; set; }

    public decimal CalcularDesconto()
    {
        if (Tipo == "VIP" && TotalCompras > 1000)
        {
            return 0.2m;
        }

        return 0;
    }
}
</pre>



## 3 - Intimidade Inapropriada

O "Intimidade Inapropriada" ocorre quando uma classe tem acesso direto aos detalhes internos de outra classe, como seus atributos ou métodos privados. Isso pode levar a um acoplamento excessivo entre as classes, tornando o código mais difícil de manter e evoluir. Para resolver esse problema, é importante garantir que as classes se comuniquem apenas por meio de interfaces públicas, e que os detalhes internos sejam encapsulados e protegidos.

Forma ruim em c# :
<pre>
class Pedido
{
    public decimal ValorTotal;
}

class PedidoService
{
    public void AplicarDesconto(Pedido pedido)
    {
        // mexendo diretamente no atributo 😬
        if (pedido.ValorTotal > 100)
        {
            pedido.ValorTotal -= 10;
        }
    }
}

</pre>

🚨 Problema:
PedidoService conhece detalhes internos de Pedido
está manipulando diretamente o estado

👉 Isso é intimidade demais entre classes

Forma correta
<pre>
class Pedido
{
    public decimal ValorTotal { get; private set; }

    public void AplicarDesconto()
    {
        if (ValorTotal > 100)
        {
            ValorTotal -= 10;
        }
    }
}

class PedidoService
{
    public void Processar(Pedido pedido)
    {
        pedido.AplicarDesconto(); // 👌 delega responsabilidade
    }
}


</pre>

## 📊 Diferença rápida

| Smell                     | Problema                                      |
|--------------------------|-----------------------------------------------|
| Feature Envy             | método deveria estar em outra classe          |
| Intimidade Inapropriada  | classes se conhecem demais                    |


## 4 - God Class (Classe Deus)

Classes que são altamente acopladas, elas tem muitas responsabilidades, a idéia encontrar maneiras de diminuir o aclopamento, seja pensando em abstrações ou mesmo dividindo as responsabilidades em classes com responsabilidades menores.

Exemplo :
<pre>
class Sistema
{
    public void CadastrarUsuario() { }

    public void CalcularPedido() { }

    public void EnviarEmail() { }

    public void GerarRelatorio() { }

    public void ConectarBanco() { }

    public void ProcessarPagamento() { }

    public void LogErro() { }
}
</pre>

Forma correta, trabalhar com classes menores:
<pre>
class UsuarioService
{
    public void CadastrarUsuario() { }
}
class PedidoService
{
    public void CalcularPedido() { }
}
class EmailService
{
    public void EnviarEmail() { }
}

class RelatorioService
{
    public void GerarRelatorio() { }
}

class PagamentoService
{
    public void ProcessarPagamento() { }
}

class Logger
{
    public void LogErro() { }
}



</pre>

## 5 - Divergente Changes


