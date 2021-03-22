using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers.Requests
{
    public class VaerktoejsKasseRequest
    {
        public DateTime VTKAnskaffet { get; set; }
        public string VTKFabrikat { get; set; }
        public string VTKModel { get; set; }
        public string VTKSerienummer { get; set; }
        public string VTKFarve { get; set; }
        public int HaandvaerkerId { get; set; }
        public HaandVaerkerRequest Haandvaerker { get; set; }
    }
}
