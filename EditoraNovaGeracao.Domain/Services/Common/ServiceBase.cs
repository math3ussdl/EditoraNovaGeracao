using EditoraNovaGeracao.Shared.Communication.Interfaces;
using System;
using System.Collections.Generic;

namespace EditoraNovaGeracao.Domain.Services.Common
{
    public class ServiceBase<TEntity, TId> : IDisposable, IResourcesCommunicationBase<TEntity, TId>
        where TEntity : class
        where TId : struct
    {
        private readonly IResourcesCommunicationBase<TEntity, TId> _repository;

        public ServiceBase(IResourcesCommunicationBase<TEntity, TId> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity data)
        {
            _repository.Add(data);
        }

        public TEntity GetById(TId id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity data)
        {
            _repository.Update(data);
        }

        public void Remove(TEntity data)
        {
            _repository.Remove(data);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
