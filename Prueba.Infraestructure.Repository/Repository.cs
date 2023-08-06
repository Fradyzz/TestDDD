using System.Data.Common;

namespace Prueba.Infraestructure.Repository
{
    public class Repository
    {
        protected readonly string schema;
        protected readonly DbTransaction transaction;
        protected readonly DbConnection db;
        public Repository(DbTransaction transaction)
        {
            this.transaction = transaction;
            if (transaction == null) throw new ArgumentNullException();
            db = transaction.Connection;
            schema = transaction.Connection.Database;
        }
    }
}