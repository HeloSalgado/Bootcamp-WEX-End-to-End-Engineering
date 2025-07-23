using System.Text;
using ExemploFundamentos.Common.Models;

Pessoa pessoa = new()
{
    Nome = "João",
    Idade = 30
};
pessoa.Apresentar();

DateTime dataAtual = DateTime.Now; // Obtendo a data atual
Console.WriteLine($"Data atual: {dataAtual:dd/MM/yyyy HH:mm:ss}"); // Formatação de data

int a = Convert.ToInt32("5"); // Conversão explícita de string para int
int b = int.Parse("5"); // Outra forma de conversão explícita de string para int

int inteiro = 5;
string c = inteiro.ToString(); // Conversão implícita de int para string
// Conversão explícita de int para string usando ToString()
inteiro.ToString();

Calculadora calculadora = new(); // Instância da classe Calculadora
calculadora.Somar(10, 5);
calculadora.Sutrair(10, 5);
calculadora.Multiplicar(10, 5);
calculadora.Dividir(10, 5);
calculadora.Potencia(2, 3);
calculadora.Seno(30);
calculadora.Coseno(30);
calculadora.Tangente(30);
calculadora.RaizQuadrada(25);


// Arrays e listas
int[] arrayInteiros = new int[3];
arrayInteiros[0] = 12;
arrayInteiros[1] = 34;
arrayInteiros[2] = 56;

// Exibindo os valores do array com for
for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Valor do array na posição {i}: {arrayInteiros[i]}");
}

// Exibindo os valores do array com foreach
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Valor do array: {valor}");
}

int[] arraysInteirosDobrados = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arraysInteirosDobrados, arrayInteiros.Length);

// Redimensionando o array
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("RJ");
listaString.Add("MG");
// Exibindo os valores da lista com for
Console.WriteLine("Exibindo valores da lista com for:");
for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Valor da lista na posição {i}: {listaString[i]}");
}

// Exibindo os valores da lista com foreach
Console.WriteLine("Exibindo valores da lista com foreach:");
foreach (string valor in listaString)
{
    Console.WriteLine($"Valor da lista: {valor}");
}