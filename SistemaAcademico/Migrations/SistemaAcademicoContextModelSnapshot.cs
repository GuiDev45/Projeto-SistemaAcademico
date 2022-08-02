﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaAcademico.Data;

#nullable disable

namespace SistemaAcademico.Migrations
{
    [DbContext(typeof(SistemaAcademicoContext))]
    partial class SistemaAcademicoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SistemaAcademico.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MatriculaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResultadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatriculaId");

                    b.HasIndex("ResultadoId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("SistemaAcademico.Models.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Nota")
                        .HasColumnType("float");

                    b.Property<int?>("ResultadoId")
                        .HasColumnType("int");

                    b.Property<int>("TurmaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ResultadoId");

                    b.HasIndex("TurmaId");

                    b.ToTable("Avaliacao");
                });

            modelBuilder.Entity("SistemaAcademico.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NotaMinima")
                        .HasColumnType("float");

                    b.Property<double>("NotaPrevista")
                        .HasColumnType("float");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("SistemaAcademico.Models.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("Prestacoes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Matricula");
                });

            modelBuilder.Entity("SistemaAcademico.Models.Resultado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("NotaObtida")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Resultado");
                });

            modelBuilder.Entity("SistemaAcademico.Models.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CursosId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MatriculaId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroTurma")
                        .HasColumnType("int");

                    b.Property<int>("Vagas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CursosId");

                    b.HasIndex("MatriculaId");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("SistemaAcademico.Models.Aluno", b =>
                {
                    b.HasOne("SistemaAcademico.Models.Matricula", null)
                        .WithMany("Alunos")
                        .HasForeignKey("MatriculaId");

                    b.HasOne("SistemaAcademico.Models.Resultado", null)
                        .WithMany("Alunos")
                        .HasForeignKey("ResultadoId");
                });

            modelBuilder.Entity("SistemaAcademico.Models.Avaliacao", b =>
                {
                    b.HasOne("SistemaAcademico.Models.Resultado", null)
                        .WithMany("Avaliacoes")
                        .HasForeignKey("ResultadoId");

                    b.HasOne("SistemaAcademico.Models.Turma", "Turma")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("TurmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("SistemaAcademico.Models.Turma", b =>
                {
                    b.HasOne("SistemaAcademico.Models.Curso", "Cursos")
                        .WithMany("Turmas")
                        .HasForeignKey("CursosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaAcademico.Models.Matricula", null)
                        .WithMany("Turmas")
                        .HasForeignKey("MatriculaId");

                    b.Navigation("Cursos");
                });

            modelBuilder.Entity("SistemaAcademico.Models.Curso", b =>
                {
                    b.Navigation("Turmas");
                });

            modelBuilder.Entity("SistemaAcademico.Models.Matricula", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("Turmas");
                });

            modelBuilder.Entity("SistemaAcademico.Models.Resultado", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("Avaliacoes");
                });

            modelBuilder.Entity("SistemaAcademico.Models.Turma", b =>
                {
                    b.Navigation("Avaliacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
