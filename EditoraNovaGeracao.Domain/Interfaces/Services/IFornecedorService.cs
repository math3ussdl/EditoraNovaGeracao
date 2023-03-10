using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Shared.Communication.Interfaces;
using System;

namespace EditoraNovaGeracao.Domain.Interfaces.Services
{
    public interface IFornecedorService : IServiceCommunication<Fornecedor, Guid>
    {
    }
}
