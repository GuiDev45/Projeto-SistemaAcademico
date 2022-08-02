namespace SistemaAcademico.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public int NumeroTurma { get; set; }
        public DateTime Inicio { get; set; }
        public int Vagas { get; set; }
        public Curso Cursos { get; set; }

        public ICollection<Avaliacao> Avaliacoes { get; set; }

        public Turma()
        {
        }

        public Turma(int id, int numeroTurma, DateTime inicio, int vagas, Curso cursos)
        {
            Id = id;
            NumeroTurma = numeroTurma;
            Inicio = inicio;
            Vagas = vagas;
            Cursos = cursos;
        }

        public void AddAvaliacao(Avaliacao avaliacoes)
        {
            Avaliacoes.Add(avaliacoes);
        }
        public void RemoveAvaliacao(Avaliacao avaliacoes)
        {
            Avaliacoes.Remove(avaliacoes);
        }
    }
}
