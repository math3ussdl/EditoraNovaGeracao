using EditoraNovaGeracao.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace EditoraNovaGeracao.Infrastructure.Data.EntityConfig
{
    public class LivroConfiguration : EntityTypeConfiguration<Livro>
    {
        public LivroConfiguration()
        {
            HasKey(l => l.Id);

            Property(l => l.Titulo)
                .IsRequired()
                .HasMaxLength(120);

            Property(l => l.Autor)
                .HasMaxLength(60);

            Property(l => l.Preco)
                .IsRequired();

            HasRequired(l => l.Categoria)
                .WithMany()
                .HasForeignKey(l => l.CategoriaId);

            HasRequired(l => l.Fornecedor)
                .WithMany()
                .HasForeignKey(l => l.FornecedorId);
        }
    }
}
