using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Shared.Communication.Interfaces;
using System;
using System.Collections.Generic;

namespace EditoraNovaGeracao.Application.Interfaces
{
    public interface ILivroAppService : IResourcesCommunicationBase<Livro, Guid>
    {
        IEnumerable<Livro> GetLivrosByCategoria(Guid categoriaId);
        IEnumerable<Livro> GetLivrosByFornecedor(Guid fornecedorId);
    }
}
