using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_MSPR.Model
{
    public class Promotion
    {
        public int ID { get; set; }
        public int CodePromo { get; set; }
        public DateTime PromoDateDeb { get; set; }
        public DateTime PromoDateFin { get; set; }
    }
}
