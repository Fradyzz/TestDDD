namespace Prueba.Domain.SeedWork.Interaces
{
    public interface IRepository <T> : ICrud<T> where T : class
    {
    }
}