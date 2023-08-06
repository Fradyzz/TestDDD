using Prueba.Infraestructure.Repository.Repositories;

namespace Prueba.Infraestructure.Repository
{
    public interface IUnitOfWork : IUnitOfWorkBase
    {
        CabinetRepository CabinetRepository { get; }
    }
}