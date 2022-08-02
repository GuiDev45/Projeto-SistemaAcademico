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
        public SistemaAcademicoContext (DbContextOptions<SistemaAcademicoContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaAcademico.Models.Curso> Curso { get; set; } = default!;
    }
}
