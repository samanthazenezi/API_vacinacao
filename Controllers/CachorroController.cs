using Api_Vacinacao_Cachorro.Models;
using Api_Vacinacao_Cachorro.Service;
using Microsoft.AspNetCore.Mvc;

namespace Api_Vacinacao_Cachorro.Controllers
{
    [ApiController]
    [Route("Cachorro")]
    public class CachorroController : ControllerBase
    {
        private readonly CachorroService _service;

        public CachorroController(CachorroService cachorroService)
        {
            _service = cachorroService;
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarCachorro(CachorroModel dog)
        {
            _service.listaDeCachorros.Add(dog);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> ListarCachorros()
        {
            return Ok(_service.listaDeCachorros);
        }

        [HttpGet("{idCachorro}")]
        public async Task<IActionResult> ProcurarCachorro(string nome)
        {
            var cachorro = _service.listaDeCachorros.Find(c => c.Nome == nome);
            if (cachorro != null)
            {
                return Ok(cachorro);
            }
            else { return BadRequest(); }
        }

        [HttpPost("{idCachorro}/vacina")]
        public async Task<IActionResult> RegistrarVacina(string nome, VacinaModel vacina)
        {
            var cachorro = _service.listaDeCachorros.Find(c => c.Nome == nome);
            if (cachorro != null)
            {
                cachorro.Vacinas.Add(vacina);
                return Ok(vacina);
            }
            else { return BadRequest(); }
        }

        [HttpDelete("{idCachorro}")]
        public async Task<IActionResult> ExcluirCachorro(int idCachorro)
        {
            var cachorro = _service.listaDeCachorros.Find(c => c.IdCachorro == idCachorro);
            if (cachorro != null)
            {
                return Ok();
            }
            else { return BadRequest(); }
        }
    }
}
