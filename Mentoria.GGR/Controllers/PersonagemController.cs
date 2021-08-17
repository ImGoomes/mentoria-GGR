using Mentoria.GGR.Lib.Data;
using Mentoria.GGR.Lib.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mentoria.GGR.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonagemController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public PersonagemController (ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        [HttpGet]
        public IEnumerable<Personagem> Get()
        {
           var lista = _context.Personagens.ToArray();
            return lista;
        }

        [HttpPost]
        public async Task<Personagem> Post([FromBody] Personagem personagem)
        {

            personagem.CriadoEm = DateTime.Now; //Pegando a hora atual

           _context.Personagens.Add(personagem);
            await _context.SaveChangesAsync();

            return personagem;
        }
    }
}
