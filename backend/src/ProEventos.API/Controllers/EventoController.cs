using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        
        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;


        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id); //retorna nossos dados 
        }
        [HttpPost]
        public string Post()
        {
            return "Value do Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Value do Put  com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Value do Delete id = {id}";
        }
    }
}
