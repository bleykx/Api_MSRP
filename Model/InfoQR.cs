using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_MSPR.Model
{
    public class InfoQR
    {
        public int IdPromo { get; set; }
        public int IdQRCode { get; set; }
        public string Localisation { get; set; }
        public DateTime DateScan { get; set; }
    }
}
