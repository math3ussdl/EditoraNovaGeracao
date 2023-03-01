using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Domain.Interfaces.Common;
using System;
using System.Collections.Generic;

namespace EditoraNovaGeracao.Domain.Interfaces
{
    public interface IEstoqueRepository : IRepositoryBase<Estoque, Guid>
    {
        IEnumerable<Estoque> GetEstoquesByLivro(Guid livroId);
    }
}
