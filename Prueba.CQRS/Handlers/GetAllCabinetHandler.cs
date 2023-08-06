using MediatR;
using Prueba.CQRS.Queries;
using Prueba.CQRS.Response;
using Prueba.Domain.CainetAggregate;
using Prueba.Infraestructure.Repository;

namespace Prueba.CQRS.Handlers
{
    public class GetAllCabinetHandler : IRequestHandler<GetAllCabinetQuery, List<GetAllCabinetResponse?>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAllCabinetHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<GetAllCabinetResponse?>> Handle(GetAllCabinetQuery request, CancellationToken cancellationToken)
        {
            List<Cabinet?> Cabinets = new();
            List<GetAllCabinetResponse?> CabinetsResponse = new();
            await unitOfWork.BeginAsync();
            
            try
            {
                 Cabinets = await unitOfWork.CabinetRepository.GetAllAsync(cancellationToken);
            }
            catch (Exception)
            {
                unitOfWork.Rollback();
            }
            finally { unitOfWork.Dispose(); }
            foreach (var cab in Cabinets)
            {
                CabinetsResponse.Add(new GetAllCabinetResponse { Id = cab.Id.Value, Name = cab.Name.Value, Description = cab.Description.Value, Path = cab.Path.Value});
            }
            return CabinetsResponse;
        }
    }
}