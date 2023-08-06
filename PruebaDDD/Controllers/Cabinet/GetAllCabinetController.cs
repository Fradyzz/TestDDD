using MediatR;
using Microsoft.AspNetCore.Mvc;
using Prueba.CQRS.Queries;
using Prueba.CQRS.Response;

namespace PruebaDDD.Controllers.Cabinet
{
    [Route("api/getallcabinets")]
    [ApiController]
    public class GetAllCabinetController : ControllerBase
    {
        private readonly IMediator mediator;

        public GetAllCabinetController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCabinet()
        {
            List<GetAllCabinetResponse?> CabinetResponse = new();
            try
            {
                CabinetResponse = await mediator.Send(new GetAllCabinetQuery());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok(CabinetResponse);
        }
    }
}