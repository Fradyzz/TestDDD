namespace Prueba.Domain.SeedWork.Interaces
{
    public interface IGetAll<T> where T : class
    {
        List<T?> GetAll(CancellationToken cancellationToken = default);
        Task<List<T?>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}