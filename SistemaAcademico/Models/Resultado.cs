namespace SistemaAcademico.Models
{
    public class Resultado
    {
        public double NotaObtida { get; set; }

        public ICollection<Aluno> Alunos { get; set; }
        public ICollection<Avaliacao> Avaliacoes { get; set; }

        public Resultado()
        {
        }

        public Resultado(double notaObtida)
        {
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
