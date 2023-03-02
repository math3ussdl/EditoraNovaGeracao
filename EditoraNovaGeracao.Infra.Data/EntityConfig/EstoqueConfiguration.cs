using EditoraNovaGeracao.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace EditoraNovaGeracao.Infrastructure.Data.EntityConfig
{
    public class EstoqueConfiguration : EntityTypeConfiguration<Estoque>
    {
        public EstoqueConfiguration()
        {
            HasKey(e => e.Id);

            Property(e => e.Quantidade)
                .IsRequired();

            HasRequired(e => e.Livro)
                .WithMany()
                .HasForeignKey(e => e.LivroId);
        }
    }
}
