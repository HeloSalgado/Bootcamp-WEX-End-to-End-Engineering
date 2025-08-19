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

// Datetime
string dataString = "2025-02-09 18:00";

bool sucesso = DateTime.TryParseExact(dataString,
                       "yyyy-MM-dd HH:mm",
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out DateTime dataConvertida);

if (sucesso)
{
    Console.WriteLine($"Data convertida com sucesso: {dataConvertida}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida.");
}

// Leitura de arquivo
try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("Arquivo não encontrado: " + ex.Message);
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine("Diretório não encontrado: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Ocorreu uma exceção genérica: " + ex.Message);
}
finally
{
    Console.WriteLine("Operação de leitura finalizada.");
}

// Usando Throw para exceções personalizadas
new ExemploExcecao().Metodo1();