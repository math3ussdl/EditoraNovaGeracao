using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.Domain.Interfaces;
using EditoraNovaGeracao.Infrastructure.Data.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EditoraNovaGeracao.Infrastructure.Data.Repositories
{
    public class LivroRepository : RepositoryBase<Livro, Guid>, ILivroRepository
    {
        public IEnumerable<Livro> GetLivrosByCategoria(Guid categoriaId)
        {
            return Db.Livros.Where(l => l.CategoriaId == categoriaId);
        }

        public IEnumerable<Livro> GetLivrosByFornecedor(Guid fornecedorId)
        {
            return Db.Livros.Where(l => l.FornecedorId == fornecedorId);
        }
    }
}
