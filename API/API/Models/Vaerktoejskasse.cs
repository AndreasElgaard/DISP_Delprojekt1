using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Vaerktoejskasse
    {
        public int VTKid { get; set; }

        public DateTime VTKAnskaffet { get; set; }

        public string VTKFabrikant { get; set; }

        public string VTKFarve { get; set; }

        public Haandvaerker VTKEjesAF { get; set; }

        public List<Vaerktoej> VTKVearktoejer { get; set; }

        public string VTKModel { get; set; }

    }
}
