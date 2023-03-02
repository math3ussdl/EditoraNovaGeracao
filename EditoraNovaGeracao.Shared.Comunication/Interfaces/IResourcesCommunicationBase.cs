using System.Collections.Generic;

namespace EditoraNovaGeracao.Shared.Communication.Interfaces
{
    public interface IResourcesCommunicationBase<TEntity, TId>
        where TEntity : class
        where TId : struct
    {
        void Add(TEntity data);
        TEntity GetById(TId id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity data);
        void Remove(TEntity data);
        void Dispose();
    }
}
