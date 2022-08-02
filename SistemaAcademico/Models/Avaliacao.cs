namespace SistemaAcademico.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public double Nota { get; set; }
        public DateTime Date { get; set; }

        public Turma Turma { get; set; }
    }
}
