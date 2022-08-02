namespace SistemaAcademico.Models
{
    public class Matricula
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Prestacoes { get; set; }

        public ICollection<Turma> Turmas { get; set; }
        public ICollection<Aluno> Alunos { get; set; }

        public Matricula()
        {
        }

        public Matricula(int id, DateTime data, int prestacoes)
        {
            Id = id;
            Data = data;
            Prestacoes = prestacoes;
        }

        public void AddTurma(Turma turma)
        {
            Turmas.Add(turma);
        }
        public void RemoveTurma(Turma turma)
        {
            Turmas.Remove(turma);
        }

        public void AddAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }
        public void RemoveAluno(Aluno aluno)
        {
            Alunos.Remove(aluno);
        }
    }
}
