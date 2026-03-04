using capitulo05.ExemploLivro;
using capitulo05.Refatorando;
using System;
using System.Collections.Generic;

// Criando uma fatura
var fatura = new FaturaRef(1500);

// Criando boletos
var boletos = new List<BoletoRef>
{
    new BoletoRef(400, DateTime.Today),
    new BoletoRef(300, DateTime.Today),
    new BoletoRef(300, DateTime.Today)
};

// Criando o processador
var processador = new ProcessadorDeBoletos_Ref();

// Processando
processador.Processa(boletos, fatura);

// Exibindo resultado
Console.WriteLine($"Valor da Fatura: {fatura.Valor}");
Console.WriteLine($"Total Pago: {fatura.TotalPago()}");
Console.WriteLine($"Saldo Restante: {fatura.SaldoRestante()}");
Console.WriteLine($"Fatura Está Paga? {fatura.Pago}");
Console.WriteLine($"Quantidade de Pagamentos: {fatura.Pagamentos.Count}");