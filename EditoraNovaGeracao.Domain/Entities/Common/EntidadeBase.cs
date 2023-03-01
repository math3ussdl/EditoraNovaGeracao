using System;

namespace EditoraNovaGeracao.Domain.Entities.Common
{
    public class EntidadeBase
    {
        public Guid Id { get; set; }

        public DateTimeOffset DataCriacao { get; set; }
        public DateTimeOffset DataAtualizacao { get; set; }
    }
}
