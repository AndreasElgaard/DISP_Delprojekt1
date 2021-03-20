using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers.Requests
{
    public class VaerToejsKasseRequest
    {
        public DateTime VTKAnskaffet { get; set; }
        public string VTKFabrikat { get; set; }
        public string VTKModel { get; set; }
        public string VTKSerienummer { get; set; }
        public string VTKFarve { get; set; }
    }
}
