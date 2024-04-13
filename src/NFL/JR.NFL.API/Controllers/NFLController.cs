using JR.Core.Mediator;
using JR.NFL.Contract.NFL.Query;
using JR.WebAPI.Core.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace JR.NFL.API.Controllers
{
    [Route("api/[controller]")]
    public class NFLController : BaseController
    {
        private readonly IMediatorHandler _mediator;

        public NFLController(IMediatorHandler mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(ConsultaJogosQueryResult), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetAll()
        {
            ConsultaJogosQueryRequest consultaJogosQueryRequest  = new();
            var teste = await _mediator.SendCommand(consultaJogosQueryRequest);

            return Ok(teste);
        }
    }
}
