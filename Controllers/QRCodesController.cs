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
    public class QRCodesController : ControllerBase, IQRCodes
    {
        private readonly AppDbContext _context;

        public QRCodesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/QRCodes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QRCode>>> GetQRCodes()
        {
            return await _context.QRCodes.ToListAsync();
        }

        // GET: api/QRCodes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QRCode>> GetQRCode(int id)
        {
            var qRCode = await _context.QRCodes.FindAsync(id);

            if (qRCode == null)
            {
                return NotFound();
            }

            return qRCode;
        }

        // PUT: api/QRCodes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQRCode(int id, QRCode qRCode)
        {
            if (id != qRCode.ID)
            {
                return BadRequest();
            }

            _context.Entry(qRCode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QRCodeExists(id))
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

        // POST: api/QRCodes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<QRCode>> PostQRCode(QRCode qRCode)
        {
            _context.QRCodes.Add(qRCode);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQRCode", new { id = qRCode.ID }, qRCode);
        }

        // DELETE: api/QRCodes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<QRCode>> DeleteQRCode(int id)
        {
            var qRCode = await _context.QRCodes.FindAsync(id);
            if (qRCode == null)
            {
                return NotFound();
            }

            _context.QRCodes.Remove(qRCode);
            await _context.SaveChangesAsync();

            return qRCode;
        }

        public bool QRCodeExists(int id)
        {
            return _context.QRCodes.Any(e => e.ID == id);
        }
    }
}
