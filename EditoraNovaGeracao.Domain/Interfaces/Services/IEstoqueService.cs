using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Shared.Communication.Interfaces;
using System;
using System.Collections.Generic;

namespace EditoraNovaGeracao.Domain.Interfaces.Services
{
    public interface IEstoqueService : IServiceCommunication<Estoque, Guid>
    {
        IEnumerable<Estoque> GetEstoquesByLivro(Guid livroId);
    }
}
