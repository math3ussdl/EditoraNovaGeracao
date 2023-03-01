using EditoraNovaGeracao.Domain.Entities.Common;
using System;

namespace EditoraNovaGeracao.Domain.Entities
{
    public class Estoque : EntidadeBase
    {
        public int Quantidade { get; set; }

        public Guid LivroId { get; set; }
        public virtual Livro Livro { get; set; }
    }
}
