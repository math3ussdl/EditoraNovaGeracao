using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Domain.Interfaces.Repositories;
using EditoraNovaGeracao.Domain.Interfaces.Services;
using EditoraNovaGeracao.Domain.Services.Common;
using System;
using System.Collections.Generic;

namespace EditoraNovaGeracao.Domain.Services
{
    public class LivroService : ServiceBase<Livro, Guid>, ILivroService
    {
        private readonly ILivroRepository _livroRepository;
        public LivroService(ILivroRepository livroRepository) : base(livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public IEnumerable<Livro> GetLivrosByCategoria(Guid categoriaId)
        {
            return _livroRepository.GetLivrosByCategoria(categoriaId);
        }

        public IEnumerable<Livro> GetLivrosByFornecedor(Guid fornecedorId)
        {
            return _livroRepository.GetLivrosByFornecedor(fornecedorId);
        }
    }
}
