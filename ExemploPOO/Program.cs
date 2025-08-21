using ExemploPOO.Interfaces;
using ExemploPOO.Models;

Pessoa p1 = new("Heloisa");
p1.Idade = 20;
p1.Apresentar();

ContaCorrente cc = new(9292, 200.50m);
cc.Sacar(50);
cc.ExibirSaldo();

Aluno aluno = new("Sofia");
aluno.Idade = 13;
aluno.Nota = 8.9;
aluno.Apresentar();

Professor professor = new("Reinaldo");
professor.Idade = 50;
professor.Salario = 2000;
professor.Apresentar();

Corrente corrente = new();
corrente.Creditar(200);
corrente.ExibirSaldo();

Computador c = new();
Console.WriteLine(c.ToString());