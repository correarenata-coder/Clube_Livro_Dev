# Capitulo 10 - Métricas de código

## Introdução
Hoje em dia criar código de qualidade é essencial para o sucesso de um projeto. idade do código. Neste capítulo, vamos explorar algumas dessas métricas e como elas podem ser aplicadas para melhorar a qualidade do código. Vamos explorar algumas métricas de código:


## Complexidade Ciclomática

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

Quanto maior esse número, mais complexo é o método. Esse número é conhecido por *Número de McCabe*


