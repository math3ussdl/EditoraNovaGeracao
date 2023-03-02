namespace EditoraNovaGeracao.Shared.Communication.Interfaces
{
    public interface IServiceCommunication<TEntity, TId> : IResourcesCommunicationBase<TEntity, TId>
        where TEntity : class
        where TId : struct
    {
    }
}
