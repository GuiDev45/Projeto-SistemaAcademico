namespace SistemaAcademico.Models
{
    public class Resultado
    {
        public int Id { get; set; }
        public double NotaObtida { get; set; }

        public ICollection<Aluno> Alunos { get; set; }
        public ICollection<Avaliacao> Avaliacoes { get; set; }

        public Resultado()
        {
        }

        public Resultado(int id, double notaObtida)
        {
            Id = id;
            NotaObtida = notaObtida;
        }

        public void AddAluno(Aluno alunos)
        {
            Alunos.Add(alunos);
        }
        public void RemoveAluno(Aluno alunos)
        {
            Alunos.Remove(alunos);
        }

        public void AddAvaliacao(Avaliacao avaliacoes)
        {
            Avaliacoes.Add(avaliacoes);
        }

    }
}
