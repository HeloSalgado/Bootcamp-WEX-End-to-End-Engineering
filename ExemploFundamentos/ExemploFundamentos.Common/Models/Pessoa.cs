namespace ExemploFundamentos.Common.Models
{
    /// <summary>
    /// Classe que representa uma pessoa com nome e idade.
    /// </summary>
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        /// <summary>
        /// Método que apresenta as informações da pessoa.
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}