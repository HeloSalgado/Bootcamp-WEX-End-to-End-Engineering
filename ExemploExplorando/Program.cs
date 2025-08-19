using System.ComponentModel;
using ExemploExplorando.Models;
using System.Globalization;

Pessoa p1 = new Pessoa(nome: "Heloisa", sobrenome: "Salgado", idade: 20);
Pessoa p2 = new Pessoa("João", "Silva", 25);
p1.Apresentar();

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

// Manipulando valores
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
decimal valorMonetario = 82.40m;
Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));