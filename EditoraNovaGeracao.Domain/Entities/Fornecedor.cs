using EditoraNovaGeracao.Domain.Entities.Common;
using System.Collections.Generic;

namespace EditoraNovaGeracao.Domain.Entities
{
    public class Fornecedor : EntidadeBase
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public virtual IEnumerable<Livro> Livros { get; set; }
    }
}
