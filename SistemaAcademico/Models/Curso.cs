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
    }
}
