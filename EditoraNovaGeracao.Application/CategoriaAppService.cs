using EditoraNovaGeracao.Application.Common;
using EditoraNovaGeracao.Application.Interfaces;
using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Domain.Interfaces.Services;
using System;

namespace EditoraNovaGeracao.Application
{
    public class CategoriaAppService : AppServiceBase<Categoria, Guid>, ICategoriaAppService
    {
        public CategoriaAppService(ICategoriaService service) : base(service)
        {
        }
    }
}
