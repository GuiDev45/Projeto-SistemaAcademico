namespace SistemaAcademico.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public double Valor { get; set; }
        public double NotaPrevista { get; set; }
        public double NotaMinima { get; set; }
        public ICollection<Turma> Turmas { get; set; }

        public Curso()
        {
        }

        public Curso(int id, string nome, int cargaHoraria, double valor, double notaPrevista, double notaMinima)
        {
            Id = id;
            Nome = nome;
            CargaHoraria = cargaHoraria;
            Valor = valor;
            NotaPrevista = notaPrevista;
            NotaMinima = notaMinima;
        }

        public void AddTurma(Turma turma)
        {
            Turmas.Add(turma);
        }
        public void RemoveTurma(Turma turma)
        {
            Turmas.Remove(turma);
        }
    }
}
