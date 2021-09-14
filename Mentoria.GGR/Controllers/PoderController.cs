using Mentoria.GGR.Lib.Data;
using Mentoria.GGR.Lib.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mentoria.GGR.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PoderController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public PoderController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        [HttpGet]
        public IEnumerable<Poder> Get()
        {
           var lista = _context.Poderes.ToArray().Where(x => x.Ativo == true);
            return lista;
        }

        [HttpPost]
        public async Task<Poder> Post([FromBody] Poder poder)
        {
            poder.CriadoEm = DateTime.Now; //Pegando a hora atual

           _context.Poderes.Add(poder);
            await _context.SaveChangesAsync();

            return poder;
        }

        [HttpPut("{id}")]
        public async Task<Poder> Put([FromBody] Poder poder, int id)
        {
            var poderRes = await _context.Poderes.FirstOrDefaultAsync(x => x.ID == id);

            poder.ID = id;
            poder.CriadoEm = poderRes.CriadoEm;
            poder.AtualizadoEm = DateTime.Now; //Pegando a hora atual

            _context.Entry(poder).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return poder;
        }
    }
}
