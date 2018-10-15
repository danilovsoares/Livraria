using Livraria.Domain.Livros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Infra.Data.Livros.Mappings
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.Property(c => c.Id)
                .HasColumnName("LivroId");

            builder.Property(c => c.Titulo)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Descricao)
                .HasColumnType("varchar(255)")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(c => c.Autor)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Editora)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.NumeroEdicao)
                .HasColumnType("int")
                .HasMaxLength(7)
                .IsRequired();

            builder.Property(c => c.AnoEdicao)
                .HasColumnType("int")
                .HasMaxLength(4)
                .IsRequired();

            builder.Property(c => c.ISBN)
              .HasColumnType("varchar(50)")
              .HasMaxLength(50)
              .IsRequired();
        }
    }
}
