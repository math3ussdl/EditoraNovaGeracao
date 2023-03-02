using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Domain.Interfaces.Repositories;
using EditoraNovaGeracao.Domain.Interfaces.Services;
using EditoraNovaGeracao.Domain.Services.Common;
using System;

namespace EditoraNovaGeracao.Domain.Services
{
    public class CategoriaService : ServiceBase<Categoria, Guid>, ICategoriaService
    {
        public CategoriaService(ICategoriaRepository categoriaRepository) : base(categoriaRepository)
        {
        }
    }
}
