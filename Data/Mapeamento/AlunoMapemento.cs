using JovemProgramadorWeb.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using JovenProgramadorWed.Models;

namespace JovemProgramadorWeb.Data.Mapeamento
{

    public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(t => t.Codigo);

            builder.Property(t => t.Nome).HasColumnType("varchar(50)");
            builder.Property(t => t.Matricula).HasColumnType("varchar(50)");
            builder.Property(t => t.DataNascimento).HasColumnType("date");
            builder.Property(t => t.Cpf).HasColumnType("int");
            builder.Property(t => t.Cep).HasColumnType("int");
            builder.Property(t => t.Endereco).HasColumnType("varchar(50)");
            builder.Property(t => t.Bairro).HasColumnType("varchar(50)");
            builder.Property(t => t.Cidade).HasColumnType("varchar(50)");
            builder.Property(t => t.Numero).HasColumnType("int");


        }
    }
}