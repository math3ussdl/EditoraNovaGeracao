using EditoraNovaGeracao.Infrastructure.Data.Context;
using EditoraNovaGeracao.Shared.Communication.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EditoraNovaGeracao.Infrastructure.Data.Repositories.Common
{
    public class RepositoryBase<TEntity, TId> : IDisposable, IResourcesCommunicationBase<TEntity, TId>
        where TEntity : class
        where TId : struct
    {
        protected ApplicationDbContext Db = new ApplicationDbContext();

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(TId id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Add(TEntity data)
        {
            Db.Set<TEntity>().Add(data);
            Db.SaveChanges();
        }

        public void Update(TEntity data)
        {
            Db.Entry(data).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntity data)
        {
            Db.Set<TEntity>().Remove(data);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
