namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
        }
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
        
        private string _nome;
        public string Nome
        {
            get => _nome.ToUpper();
    
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        private int _idade;
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa.");
                }

                _idade = value;
            }
        }


        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }
    } 
}