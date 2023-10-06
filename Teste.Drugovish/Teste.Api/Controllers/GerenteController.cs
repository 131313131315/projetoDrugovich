using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Teste.Domain.Interfaces.Services.Cliente;
using Teste.Domain.Interfaces.Services.Gerente;

namespace Teste.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerenteController : ControllerBase
    {
        private readonly IGerenteServices _service;
        public GerenteController(IGerenteServices service)
        {
            _service = service;
        }

        [HttpGet("entrar")]
        [HttpGet]
        public async Task<ActionResult> Login(string nome)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 bad request - solicitação inválida
            }

            try
            {
                return Ok(await _service.Login(nome));

            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
