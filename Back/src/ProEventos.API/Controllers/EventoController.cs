using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController(ILogger<EventoController> logger)
        {

        }

        [HttpGet]
        public List<Evento> Get()
        {
            return new List<Evento>(){
                new Evento(){
                EventoID = 1,
                Tema = "Encontro Turma",
                Local = "Rincão",
                QtdPessoas = 20,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                Lote = "Primeiro",
                ImagemUrl = "NULL",
            },
            new Evento(){
                EventoID = 1,
                Tema = "Encontro Turma",
                Local = "Rincão",
                QtdPessoas = 20,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                Lote = "Primeiro",
                ImagemUrl = "NULL",
            }
        };
    }

    [HttpPost]
    public string Post()
    {
        return "Método POST";
    }

    [HttpDelete("{ID}")]
    public string DELETE(int ID)
    {
        return $"Método DROPATUDO com ID {ID}";
    }
}
}