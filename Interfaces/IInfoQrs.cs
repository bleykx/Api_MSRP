using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_MSPR.Model;

namespace API_MSPR.src
{
    public interface IInfoQrs
    {
        Task<ActionResult<IEnumerable<InfoQR>>> GetInfoQRs();
        Task<ActionResult<InfoQR>> GetInfoQR(int id);
        Task<IActionResult> PutInfoQR(int id, InfoQR infoQR);
        Task<ActionResult<InfoQR>> PostInfoQR(InfoQR infoQR);
        Task<ActionResult<InfoQR>> DeleteInfoQR(int id);
        bool InfoQRExists(int id);
    }
}
