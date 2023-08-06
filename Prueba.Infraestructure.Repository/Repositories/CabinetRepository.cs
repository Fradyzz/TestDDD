using Dapper;
using Prueba.Domain.CainetAggregate;
using Prueba.Domain.CainetAggregate.DTOs;
using Prueba.Domain.CainetAggregate.Interfaces;
using Prueba.Domain.CainetAggregate.ValueIObjects;
using Prueba.Domain.SeedWork.ValueObjects;
using System.Data.Common;

namespace Prueba.Infraestructure.Repository.Repositories
{
    public class CabinetRepository : Repository, ICabinetRepository
    {
        public CabinetRepository(DbTransaction transaction) : base(transaction)
        {
        }

        public Cabinet? Create(Cabinet entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Cabinet?> CreateAsync(Cabinet entitt, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public List<Cabinet?> GetAll(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Cabinet?>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            List<Cabinet?> Cabinets = new();
            var query = $"Execute [{schema}].[GetAllCabinet]";
            try
            {
                var cabs = await db.QueryAsync<CabinetDTO>(query, transaction:transaction).ConfigureAwait(false);
                if (cabs != null)
                {
                    foreach (var cab in cabs)
                    {
                        Cabinets.Add(new Cabinet(IdValue.From(cab.Id), NameValue.From(cab.Name), DescriptionValue.From(cab.Description), PathValue.From(cab.Path)));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Cabinets;
        }
    }
}