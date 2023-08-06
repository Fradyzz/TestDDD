namespace Prueba.Domain.SeedWork.Interaces
{
    public interface ICrud<T> : ICreate<T>, IGetAll<T> where T : class
    {
    }
}