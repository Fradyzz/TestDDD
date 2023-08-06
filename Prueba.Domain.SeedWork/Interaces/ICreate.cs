namespace Prueba.Domain.SeedWork.Interaces
{
    public interface ICreate<T> where T : class
    {
        T? Create(T entity, CancellationToken cancellationToken = default);
        Task<T?> CreateAsync(T entitt, CancellationToken cancellationToken = default);
    }
}