using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_MSPR.Model
{
    public class QRCode
    {
        public int ID { get; set; }
        public int NbScan { get; set; }
        public int PromotionId { get; set; }
        public String Url { get; set; }
    }
}
