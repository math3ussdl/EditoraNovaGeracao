using EditoraNovaGeracao.Shared.Communication.Interfaces;
using System;
using System.Collections.Generic;

namespace EditoraNovaGeracao.Application.Common
{
    public class AppServiceBase<TEntity, TId> : IDisposable, IResourcesCommunicationBase<TEntity, TId>
        where TEntity : class
        where TId : struct
    {
        private readonly IServiceCommunication<TEntity, TId> _service;

        public AppServiceBase(IServiceCommunication<TEntity, TId> service)
        {
            _service = service;
        }

        public void Add(TEntity data)
        {
            _service.Add(data);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _service.GetAll();
        }

        public TEntity GetById(TId id)
        {
            return _service.GetById(id);
        }

        public void Remove(TEntity data)
        {
            _service.Remove(data);
        }

        public void Update(TEntity data)
        {
            _service.Update(data);
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}
