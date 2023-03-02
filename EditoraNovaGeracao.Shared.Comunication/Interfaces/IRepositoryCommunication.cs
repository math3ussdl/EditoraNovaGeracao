using EditoraNovaGeracao.Shared.Communication.Interfaces;

namespace EditoraNovaGeracao.Shared.Communication.Interfaces
{
    public interface IRepositoryCommunication<TEntity, TId> : IResourcesCommunicationBase<TEntity, TId>
        where TEntity : class
        where TId : struct
    {
    }
}
