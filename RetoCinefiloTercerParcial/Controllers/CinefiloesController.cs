using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RetoCinefiloTercerParcial.Data;
using RetoCinefiloTercerParcial.Models;

namespace RetoCinefiloTercerParcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinefiloesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CinefiloesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Cinefiloes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cinefilo>>> GetCinefilo()
        {
            return await _context.Cinefilo.ToListAsync();
        }

        // GET: api/Cinefiloes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cinefilo>> GetCinefilo(string id)
        {
            var cinefilo = await _context.Cinefilo.FindAsync(id);

            if (cinefilo == null)
            {
                return NotFound();
            }

            return cinefilo;
        }

        // PUT: api/Cinefiloes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCinefilo(string id, Cinefilo cinefilo)
        {
            if (id != cinefilo.Genero)
            {
                return BadRequest();
            }

            _context.Entry(cinefilo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CinefiloExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cinefiloes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cinefilo>> PostCinefilo(Cinefilo cinefilo)
        {
            _context.Cinefilo.Add(cinefilo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CinefiloExists(cinefilo.Genero))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCinefilo", new { id = cinefilo.Genero }, cinefilo);
        }

        // DELETE: api/Cinefiloes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCinefilo(string id)
        {
            var cinefilo = await _context.Cinefilo.FindAsync(id);
            if (cinefilo == null)
            {
                return NotFound();
            }

            _context.Cinefilo.Remove(cinefilo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CinefiloExists(string id)
        {
            return _context.Cinefilo.Any(e => e.Genero == id);
        }
    }
}
