using EditoraNovaGeracao.Domain.Entities.Common;
using System;
using System.Collections.Generic;

namespace EditoraNovaGeracao.Domain.Entities
{
    public class Livro : EntidadeBase
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }

        public Guid CategoriaId { get; set; }
        public Guid FornecedorId { get; set; }

        public virtual IEnumerable<Estoque> Estoques { get; set; }
    }
}
