using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Domain.Interfaces.Repositories;
using EditoraNovaGeracao.Domain.Interfaces.Services;
using EditoraNovaGeracao.Domain.Services.Common;
using System;
using System.Collections.Generic;

namespace EditoraNovaGeracao.Domain.Services
{
    public class EstoqueService : ServiceBase<Estoque, Guid>, IEstoqueService
    {
        private readonly IEstoqueRepository _estoqueRepository;

        public EstoqueService(IEstoqueRepository estoqueRepository) : base(estoqueRepository)
        {
            _estoqueRepository = estoqueRepository;
        }

        public IEnumerable<Estoque> GetEstoquesByLivro(Guid livroId)
        {
            return _estoqueRepository.GetEstoquesByLivro(livroId);
        }
    }
}
