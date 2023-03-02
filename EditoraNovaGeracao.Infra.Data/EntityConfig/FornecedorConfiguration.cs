using EditoraNovaGeracao.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace EditoraNovaGeracao.Infrastructure.Data.EntityConfig
{
    public class FornecedorConfiguration : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfiguration()
        {
            HasKey(f => f.Id);

            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(120);

            Property(f => f.Endereco)
                .IsRequired()
                .HasMaxLength(180);

            Property(f => f.Telefone)
                .IsRequired()
                .HasMaxLength(60);
        }
    }
}
