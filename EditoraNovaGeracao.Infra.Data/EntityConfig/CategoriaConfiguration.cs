using EditoraNovaGeracao.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace EditoraNovaGeracao.Infrastructure.Data.EntityConfig
{
    public class CategoriaConfiguration : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
