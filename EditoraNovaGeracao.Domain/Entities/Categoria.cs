using EditoraNovaGeracao.Domain.Entities.Common;
using System.Collections.Generic;

namespace EditoraNovaGeracao.Domain.Entities
{
    public class Categoria : EntidadeBase
    {
        public string Nome { get; set; }

        public virtual IEnumerable<Livro> Livros { get; set; }
    }
}
