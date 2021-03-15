using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Project.Datamodels
{
    public class VaerktoejsKasseModel
    {
        public long id { get; set; }
        public string Model { get; set; }
        public string Fabrikant { get; set; }
        public string Farve { get; set; }
        public DateTime Anskaffet { get; set; }
        public HaandvaerkerModel EjesAF { get; set; }
        public List<VaerktoejModel> Vaerktoejer { get; set; }
        
    }
}
