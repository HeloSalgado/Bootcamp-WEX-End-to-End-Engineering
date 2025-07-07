using ExemploFundamentos.Models;

Pessoa pessoa = new Pessoa();

pessoa.Nome = "João";
pessoa.Idade = 30;
pessoa.Apresentar();

DateTime dataAtual = DateTime.Now;
Console.WriteLine($"Data atual: {dataAtual:dd/MM/yyyy HH:mm:ss}");

int a = Convert.ToInt32("5");
int b = int.Parse("5");

int inteiro = 5;
string c = inteiro.ToString();