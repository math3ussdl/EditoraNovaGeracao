using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Domain.Interfaces.Common;
using System;
using System.Collections.Generic;

namespace EditoraNovaGeracao.Domain.Interfaces
{
    public interface ILivroRepository : IRepositoryBase<Livro, Guid>
    {
        IEnumerable<Livro> GetLivrosByCategoria(Guid categoriaId);
        IEnumerable<Livro> GetLivrosByFornecedor(Guid fornecedorId);
    }
}
