using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
            EventoId = 1,
            Tema = "Javascript e PHP",
            Local = "São Paulo",
            Lote = "1° Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImageURL = "jesus.png",
            },
            new Evento(){
            EventoId = 2,
            Tema = "PHP",
            Local = "São Paulo",
            Lote = "2° Lote",
            QtdPessoas = 251,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImageURL = "jesusCristo.png",
            },
             new Evento(){
            EventoId = 3,
            Tema = "JavaScript",
            Local = "Barra Funda",
            Lote = "3° Lote",
            QtdPessoas = 2,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImageURL = "papa.png",
            },
        };
        public EventoController()
        {
        
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id){
            return _evento.Where(evento => evento.EventoId == id);
        }
        [HttpPost]
        public string Post(){
            return "Value do Post";
        }

        [HttpPut("{id}")]
        public string Put(int id){
            return $"Value do Put  com id = {id}";
        }
        
        [HttpDelete("{id}")]
        public string Delete(int id){
            return $"Value do Delete id = {id}";
        }
    }
}
