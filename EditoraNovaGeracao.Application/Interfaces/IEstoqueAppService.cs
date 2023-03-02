using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Shared.Communication.Interfaces;
using System;
using System.Collections.Generic;

namespace EditoraNovaGeracao.Application.Interfaces
{
    public interface IEstoqueAppService : IResourcesCommunicationBase<Estoque, Guid>
    {
        IEnumerable<Estoque> GetEstoquesByLivro(Guid livroId);
    }
}
