using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProVentos.API.Models;
using ProVentos.API.Services;

namespace ProVentos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteService _pacienteService;

        public PacienteController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Paciente>> Get()
        {
            var pacientes = _pacienteService.ObterTodos();
            return Ok(pacientes);
        }

        [HttpGet("{id}")]
        public ActionResult<Paciente> GetById(int id)
        {
            var paciente = _pacienteService.ObterPorId(id);
            if (paciente == null)
                return NotFound();
            return Ok(paciente);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Paciente paciente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool resultado = _pacienteService.Adicionar(paciente);
            if (resultado)
                return CreatedAtAction(nameof(GetById), new { id = paciente.PacienteId }, paciente);

            return BadRequest("Não foi possível adicionar o paciente.");
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Paciente paciente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool resultado = _pacienteService.Atualizar(id, paciente);
            if (resultado)
                return NoContent();
            
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool resultado = _pacienteService.Remover(id);
            if (resultado)
                return NoContent();
            
            return NotFound();
        }
    }
}
