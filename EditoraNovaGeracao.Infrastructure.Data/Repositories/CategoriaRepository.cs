using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Domain.Interfaces;
using EditoraNovaGeracao.Infrastructure.Data.Repositories.Common;
using System;

namespace EditoraNovaGeracao.Infrastructure.Data.Repositories
{
    public class CategoriaRepository : RepositoryBase<Categoria, Guid>, ICategoriaRepository
    {
    }
}
