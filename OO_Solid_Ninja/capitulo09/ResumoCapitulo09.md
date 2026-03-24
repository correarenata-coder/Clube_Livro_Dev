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