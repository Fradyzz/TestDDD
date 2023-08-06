using Prueba.Infraestructure.Repository.Repositories;
using System.Data.Common;
using System.Data.SqlClient;

namespace Prueba.Infraestructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbConnection connection;
        private DbTransaction transaction;

        public UnitOfWork(string ConnectionString)
        {
            connection = new SqlConnection(ConnectionString);
        }
        public CabinetRepository CabinetRepository => new(transaction);

        public void Begin()
        {
            transaction = connection.BeginTransaction();
        }

        public async Task BeginAsync()
        {
            await connection.OpenAsync();
            transaction = await connection.BeginTransactionAsync();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public async Task CommitAsync()
        {
            await transaction.CommitAsync();
        }

        public void Dispose()
        {
            if (transaction != null) transaction.Dispose();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public async Task RollbackAsync()
        {
            await transaction.RollbackAsync();
        }
    }
}