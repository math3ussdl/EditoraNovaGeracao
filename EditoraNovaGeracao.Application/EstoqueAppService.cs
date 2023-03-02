using EditoraNovaGeracao.Application.Common;
using EditoraNovaGeracao.Application.Interfaces;
using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace EditoraNovaGeracao.Application
{
    public class EstoqueAppService : AppServiceBase<Estoque, Guid>, IEstoqueAppService
    {
        private readonly IEstoqueService _estoqueService;
        public EstoqueAppService(IEstoqueService service) : base(service)
        {
            _estoqueService = service;
        }

        public IEnumerable<Estoque> GetEstoquesByLivro(Guid livroId)
        {
            return _estoqueService.GetEstoquesByLivro(livroId);
        }
    }
}
