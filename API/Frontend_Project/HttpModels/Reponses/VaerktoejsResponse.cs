using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers.Responses
{
    public class VaerktoejsResponse
    {
        public int VTId { get; set; }
        public DateTime VTAnskaffet { get; set; }
        public string VTFabrikat { get; set; }
        public string VTModel { get; set; }
        public string VTSerienr { get; set; }
        public string VTType { get; set; }
        public int VaerktoejskasseId { get; set; }
        public VaerktoejsKasseResponse Vaerktoejskasse { get; set; }
    }
}
