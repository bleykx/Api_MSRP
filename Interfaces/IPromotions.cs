using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_MSPR.Model;
using Microsoft.AspNetCore.Mvc;

namespace API_MSPR.src
{
    public interface IPromotions
    {
        Task<ActionResult<IEnumerable<Promotion>>> GetPromotions();
        Task<ActionResult<Promotion>> GetPromotion(int id);
        Task<IActionResult> PutPromotion(int id, Promotion promotion);
        Task<ActionResult<Promotion>> PostPromotion(Promotion promotion);
        Task<ActionResult<Promotion>> DeletePromotion(int id);
        bool PromotionExists(int id);
    }
}
