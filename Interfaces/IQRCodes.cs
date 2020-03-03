using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_MSPR.Model;
using Microsoft.AspNetCore.Mvc;

namespace API_MSPR.src
{
    public interface IQRCodes
    {
        Task<ActionResult<IEnumerable<QRCode>>> GetQRCodes();
        Task<ActionResult<QRCode>> GetQRCode(int id);
        Task<IActionResult> PutQRCode(int id, QRCode qRCode);
        Task<ActionResult<QRCode>> PostQRCode(QRCode qRCode);
        Task<ActionResult<QRCode>> DeleteQRCode(int id);
        bool QRCodeExists(int id);
    }
}
