using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Domain.Interfaces.Common;
using System;

namespace EditoraNovaGeracao.Domain.Interfaces
{
    public interface ICategoriaRepository : IRepositoryBase<Categoria, Guid>
    {
    }
}
