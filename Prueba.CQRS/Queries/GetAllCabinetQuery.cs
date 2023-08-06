using MediatR;
using Prueba.CQRS.Response;

namespace Prueba.CQRS.Queries
{
    public record GetAllCabinetQuery : IRequest<List<GetAllCabinetResponse?>>;
}