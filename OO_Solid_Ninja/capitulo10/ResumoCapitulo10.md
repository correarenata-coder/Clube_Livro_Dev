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

## 5 - Má nomenclatura

Para uma boa usabilidade de código é essencial darmos bons nomes às variáveis, métodos e classes.
Exemplos quando os nomes não saão bons :
- não explicam o que fazem
- são genéricos demais
- confundem quem lê (inclusive você no futuro)

Exemplo :

## a) nomes genéricos demais
<pre>
{
int x = 10;
decimal v = 1000;
}
</pre>
 O que é "x" e o que é "v" ??
 Melhorar para :
 <pre>
 int quantidadeItens = 10;
decimal valorTotal = 1000;
</pre>
 

 ## b) Nomes que não representam o que o método faz
 <pre>
 void Processar()
{
    // envia email
}
 </pre>

 Melhorar para:
 <pre>
 void EnviarEmailConfirmacao()
{
}
 </pre>

 ## c) boleano mal nomeado
 <pre>
 bool status;
 </pre>
   
  Melhorar para :
  <pre>
  bool pedidoPago;
bool usuarioAtivo;
  </pre>

  ## 6 - Como avaliar os números encontrados?

  Nem tudo que é medido é importante, e nem tudo que é importante pode ser medido. As métricas de código são ferramentas úteis para identificar áreas problemáticas, mas elas não devem ser usadas como a única base para avaliar a qualidade do código. É importante considerar o contexto do projeto, as necessidades dos usuários e os objetivos de negócios ao interpretar as métricas de código. Além disso, é fundamental usar as métricas como um guia para melhorar o código, em vez de usá-las como um fim em si mesmas.

  ## 7 - Ferramentas
  Existem várias ferramentas no mercado, a mais comum é o Sonar. É uma plataforma onde se pode configurar todas essas métrica mencionadas e ele mostra a evolução  delas ao longo do tempo.Ela é disparada automaticamente, cada vez que o código é comitado.

  Alguns exemplos para serem usados no visual studio :

  - SonarLint 
  - Roslyn
  - ReSharper