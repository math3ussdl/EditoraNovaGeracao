using EditoraNovaGeracao.Application.Common;
using EditoraNovaGeracao.Application.Interfaces;
using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace EditoraNovaGeracao.Application
{
    public class LivroAppService : AppServiceBase<Livro, Guid>, ILivroAppService
    {
        private readonly ILivroService _livroService;
        public LivroAppService(ILivroService service) : base(service)
        {
            _livroService = service;
        }

        public IEnumerable<Livro> GetLivrosByCategoria(Guid categoriaId)
        {
            return _livroService.GetLivrosByCategoria(categoriaId);
        }

        public IEnumerable<Livro> GetLivrosByFornecedor(Guid fornecedorId)
        {
            return _livroService.GetLivrosByFornecedor(fornecedorId);
        }
    }
}
