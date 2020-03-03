using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_MSPR.Model;

namespace API_MSPR.src
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoQRsController : ControllerBase, IInfoQrs
    {
        private readonly AppDbContext _context;

        public InfoQRsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/InfoQRs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InfoQR>>> GetInfoQRs()
        {
            return await _context.InfoQRs.ToListAsync();
        }

        // GET: api/InfoQRs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InfoQR>> GetInfoQR(int id)
        {
            var infoQR = await _context.InfoQRs.FindAsync(id);

            if (infoQR == null)
            {
                return NotFound();
            }

            return infoQR;
        }

        // PUT: api/InfoQRs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInfoQR(int id, InfoQR infoQR)
        {
            if (id != infoQR.IdPromo)
            {
                return BadRequest();
            }

            _context.Entry(infoQR).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InfoQRExists(id))
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

        // POST: api/InfoQRs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<InfoQR>> PostInfoQR(InfoQR infoQR)
        {
            _context.InfoQRs.Add(infoQR);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InfoQRExists(infoQR.IdPromo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInfoQR", new { id = infoQR.IdPromo }, infoQR);
        }

        // DELETE: api/InfoQRs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InfoQR>> DeleteInfoQR(int id)
        {
            var infoQR = await _context.InfoQRs.FindAsync(id);
            if (infoQR == null)
            {
                return NotFound();
            }

            _context.InfoQRs.Remove(infoQR);
            await _context.SaveChangesAsync();

            return infoQR;
        }

        public bool InfoQRExists(int id)
        {
            return _context.InfoQRs.Any(e => e.IdPromo == id);
        }
    }
}
