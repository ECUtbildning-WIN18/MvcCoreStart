using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEcom.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public double Vat { get; set; }
        public double ShippingCost { get; set; }
        public string Language { get; set; }
        public string LanguageCode { get; set; }
    }
}
