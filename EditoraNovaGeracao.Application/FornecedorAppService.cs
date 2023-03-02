using EditoraNovaGeracao.Application.Common;
using EditoraNovaGeracao.Application.Interfaces;
using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Domain.Interfaces.Services;
using System;

namespace EditoraNovaGeracao.Application
{
    public class FornecedorAppService : AppServiceBase<Fornecedor, Guid>, IFornecedorAppService
    {
        public FornecedorAppService(IFornecedorService service) : base(service)
        {
        }
    }
}
