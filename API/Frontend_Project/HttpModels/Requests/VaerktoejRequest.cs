using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers.Requests
{
    public class VaerkToejRequest
    {
        public DateTime VTAnskaffet { get; set; }
        public string VTFabrikat { get; set; }
        public string VTModel { get; set; }
        public string VTSerienr { get; set; }
        public string VTType { get; set; }
        public int VaerktoejskasseId { get; set; }
        public VaerkToejRequest Vaerktoejskasse { get; set; }
    }
}
