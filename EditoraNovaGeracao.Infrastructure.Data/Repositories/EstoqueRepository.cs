using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Domain.Interfaces;
using EditoraNovaGeracao.Infrastructure.Data.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EditoraNovaGeracao.Infrastructure.Data.Repositories
{
    public class EstoqueRepository : RepositoryBase<Estoque, Guid>, IEstoqueRepository
    {
        public IEnumerable<Estoque> GetEstoquesByLivro(Guid livroId)
        {
            return Db.Estoques.Where(e => e.LivroId == livroId);
        }
    }
}
