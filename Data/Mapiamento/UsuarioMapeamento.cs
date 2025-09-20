using JovenProgramadorWed.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JovenProgramadorWed.Data.Mapiamento
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(t => t.Codigo);

            builder.Property(t => t.Email).HasColumnType("varchar(50)");
            builder.Property(t => t.Senha).HasColumnType("varchar(50)");

        }
    }
}
