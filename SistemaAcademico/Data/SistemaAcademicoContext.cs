using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaAcademico.Models;

namespace SistemaAcademico.Data
{
    public class SistemaAcademicoContext : DbContext
    {
        public SistemaAcademicoContext(DbContextOptions<SistemaAcademicoContext> options) : base(options)
        {
        }

        public DbSet<SistemaAcademico.Models.Aluno> Aluno { get; set; }
        public DbSet<SistemaAcademico.Models.Avaliacao> Avaliacao { get; set; }
        public DbSet<SistemaAcademico.Models.Curso> Curso { get; set; }
        public DbSet<SistemaAcademico.Models.Matricula> Matricula { get; set; }
        public DbSet<SistemaAcademico.Models.Resultado> Resultado { get; set; }
        public DbSet<SistemaAcademico.Models.Turma> Turma { get; set; }
    }
}
