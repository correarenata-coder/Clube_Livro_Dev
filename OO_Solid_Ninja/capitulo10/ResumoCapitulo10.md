# Capitulo 10 - Métricas de código

## Introdução
Hoje em dia criar código de qualidade é essencial para o sucesso de um projeto idade do código. Neste capítulo, vamos explorar algumas dessas métricas e como elas podem ser aplicadas para melhorar a qualidade do código. Vamos explorar algumas métricas de código:


## 1 - Complexidade Ciclomática

Ela mede quando se tem muitos possíveis caminhos diferentes ou se tem muita linha de código.

<pre> public int Conta(int a , int b) {
  int total = 0;
  if (a>10) total += a+b; 
  if (b>10) total += a*2+b;

  return total;
}
</pre>
Nesse caso temos 4 possibilidades de caminho :
- Quando ambas as condições são falsas
- Quando ambas as condições são verdadeiras
- Quando so,emte a primeria é verdadeira
- Quando somente a segunda é verdadeira

Quanto maior esse número, mais complexo é o método. Esse número é conhecido por *Número de McCabe*, sendo achar para achar esse número é preciso contar a quantidade de instruções de desvio exsitentes e adicionar 1 no final. Messe caso temos 2 ifs + 1, daria 3.


## 2 - Tamanho de métodos

Tamanho de algo também pode nos dar um feeedback sobre a qualidade do código. Segue itens a serem observados:
- Tamanho de linhas de código
- Quantidade de atributos em uma classe
- Quantidade de métodos em uma classe
- O número de variáveis declaradas dentro de um método

## 3 - Coesão e LCOM (Lack of Cohesion of Methods

É uma metrica para medir quantos métodos estão relacionados entre si.
Exemplo
<pre>
class Usuario
{
    public string Nome;
    public string Email;

    public void Salvar() { /* usa Nome */ }
    public void EnviarEmail() { /* usa Email */ }
    public void CalcularFrete() { /* não usa nada daqui */ }
}
</pre>
Classe com muitas responsabilidades tem baixa coesão, e isso pode ser um sinal de que a classe está fazendo mais do que deveria. O ideal é que cada classe tenha uma única responsabilidade, ou seja, faça apenas uma coisa. Se uma classe tem muitos métodos que não estão relacionados entre si, isso pode indicar que a classe está violando o princípio da responsabilidade única (SRP) e pode ser um candidato para refatoração.

## 4 - Acoplamento (Aferente e Eferente)

O acoplamento é uma métrica que mede o grau de dependência entre as classes. 

- Aclopamento eferente : Quando uma classe depende de diversas outras classes
- Aclopamento aferente : Mede quantas classes dependem  da classe principal