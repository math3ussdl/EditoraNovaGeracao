using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Shared.Communication.Interfaces;
using System;
using System.Collections.Generic;

namespace EditoraNovaGeracao.Domain.Interfaces.Services
{
    public interface ILivroService : IServiceCommunication<Livro, Guid>
    {
        IEnumerable<Livro> GetLivrosByCategoria(Guid categoriaId);
        IEnumerable<Livro> GetLivrosByFornecedor(Guid fornecedorId);
    }
}
