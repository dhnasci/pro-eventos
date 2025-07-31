using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProVentos.API.Models;

namespace ProVentos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _eventos = new Evento[] {
            new Evento()
            {
                EventoId = 1,
                Local = "São Paulo",
                DataEvento = DateTime.Now.ToString("dd/MM/yyyy"),
                Tema = "ProVentos 2023",
                QtdPessaos = 1000,
                ImagemURL = "https://www.example.com/imagem.jpg",
                Lote = "1º Lote"
            }, 
            new Evento()
            {
                EventoId = 2,
                Local = "Rio de Janeiro",
                DataEvento = DateTime.Now.AddDays(30).ToString("dd/MM/yyyy"),
                Tema = "ProVentos 2023 - Rio",
                QtdPessaos = 500,
                ImagemURL = "https://www.example.com/imagem2.jpg",
                Lote = "2º Lote"
            }
            };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _eventos.Where(ev => ev.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "valor pelo Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id {id}";
        }

    }
}
