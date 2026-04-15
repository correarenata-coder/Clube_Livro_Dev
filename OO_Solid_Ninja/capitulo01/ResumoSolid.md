# 📌 SOLID

## Introdução
Atualmente, escrever código de qualidade é essencial para o sucesso e a sustentabilidade de qualquer projeto de software. Um código bem estruturado facilita a manutenção, reduz erros e melhora a evolução do sistema ao longo do tempo.

Neste contexto, os princípios **SOLID** são fundamentais. Eles representam boas práticas de design orientado a objetos que ajudam a reduzir o acoplamento, aumentar a coesão e tornar o código mais flexível e escalável.

---

## 📊 Princípios SOLID

| Sigla | Nome | Descrição | Sinais de problema |
|------|------|----------|-------------------|
| **S** | Princípio da Responsabilidade Única | Uma classe deve ter apenas um único motivo para mudar. | Classes com múltiplas responsabilidades |
| **O** | Princípio do Aberto/Fechado | Classes devem estar abertas para extensão, mas fechadas para modificação. | Alterações frequentes em código existente |
| **L** | Princípio da Substituição de Liskov | Classes filhas devem poder substituir classes base sem quebrar o comportamento. | Herança que gera comportamento inesperado |
| **I** | Princípio da Segregação de Interface | Interfaces devem ser específicas e não obrigar implementações desnecessárias. | Interfaces muito grandes (“gordas”) |
| **D** | Princípio da Inversão de Dependência | Dependa de abstrações, não de implementações concretas. | Alto acoplamento entre classes |

---

## 💡 Boas práticas relacionadas

- Alta coesão: cada classe com uma única responsabilidade  
- Baixo acoplamento: dependências reduzidas entre classes  
- Facilidade de testes: código mais simples de testar  
- Escalabilidade: novas funcionalidades sem quebrar o existente  

---

## 📚 Fonte

- [Curso SOLID - Balta](https://www.youtube.com/watch?v=P5eqNeGSXRs&list=PLHlHvK2lnJneX-lsKM27WTjmNqpX_YzHF)