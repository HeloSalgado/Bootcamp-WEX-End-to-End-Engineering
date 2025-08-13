namespace ExemploExplorando.Models
{
    public class Curso
    {
        private string _nome;
        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome do curso não pode ser vazio.");
                }

                _nome = value;
            }
        }
        private List<Pessoa> _alunos = new List<Pessoa>();
        public List<Pessoa> Alunos
        {
            get => _alunos;

            set => _alunos = value;
        }

        public void AdicionarAluno(Pessoa aluno)
        {
            _alunos.Add(aluno);
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return _alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos matriculados no curso {Nome}:");
            foreach (var aluno in _alunos)
            {
                Console.WriteLine($"Nome: {aluno.NomeCompleto}");
            }
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            return _alunos.Count;
        }
    }
}