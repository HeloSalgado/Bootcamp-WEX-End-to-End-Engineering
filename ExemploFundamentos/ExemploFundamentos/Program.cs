using System.Text;
using ExemploFundamentos.Common.Models;

Pessoa pessoa = new()
{
    Nome = "João",
    Idade = 30
};
pessoa.Apresentar();

DateTime dataAtual = DateTime.Now;
Console.WriteLine($"Data atual: {dataAtual:dd/MM/yyyy HH:mm:ss}");

int a = Convert.ToInt32("5");
int b = int.Parse("5");

int inteiro = 5;
string c = inteiro.ToString();

Calculadora calculadora = new();
calculadora.Somar(10, 5);
calculadora.Sutrair(10, 5);
calculadora.Multiplicar(10, 5);
calculadora.Dividir(10, 5);
calculadora.Potencia(2, 3);
calculadora.Seno(30);
calculadora.Coseno(30);
calculadora.Tangente(30);
calculadora.RaizQuadrada(25);