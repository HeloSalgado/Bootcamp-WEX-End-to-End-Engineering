using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Heloisa", sobrenome: "Salgado", idade: 20);
Pessoa p2 = new Pessoa("João", "Silva", 25);
p1.Apresentar();

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();