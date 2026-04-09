
using capitulo02.Refatorando;

var cargo = Cargo2.Desenvolvedor;
var regra = cargo.GetRegra();

decimal salarioFinal = regra.calcula(new Funcionario2() {Cargo =cargo,Salario =5000 });


Console.WriteLine("salarioFinal=" + salarioFinal.ToString("N2"));
