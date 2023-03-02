using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Domain.Interfaces.Repositories;
using EditoraNovaGeracao.Domain.Interfaces.Services;
using EditoraNovaGeracao.Domain.Services.Common;
using System;

namespace EditoraNovaGeracao.Domain.Services
{
    public class FornecedorService : ServiceBase<Fornecedor, Guid>, IFornecedorService
    {
        public FornecedorService(IFornecedorRepository fornecedorRepository) : base(fornecedorRepository)
        {
        }
    }
}
