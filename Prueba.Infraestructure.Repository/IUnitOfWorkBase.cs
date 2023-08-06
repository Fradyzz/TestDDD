namespace Prueba.Infraestructure.Repository
{
    public interface IUnitOfWorkBase : IDisposable
    {
        void Begin();
        Task BeginAsync();
        void Commit();
        Task CommitAsync();
        void Rollback();
        Task RollbackAsync();
    }
}