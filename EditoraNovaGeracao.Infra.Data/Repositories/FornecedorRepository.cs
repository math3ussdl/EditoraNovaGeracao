using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Domain.Interfaces.Repositories;
using EditoraNovaGeracao.Infrastructure.Data.Repositories.Common;
using System;

namespace EditoraNovaGeracao.Infrastructure.Data.Repositories
{
    public class FornecedorRepository : RepositoryBase<Fornecedor, Guid>, IFornecedorRepository
    {
    }
}
