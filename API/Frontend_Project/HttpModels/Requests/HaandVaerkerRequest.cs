using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers.Requests
{
    public class HaandVaerkerRequest
    {
        public DateTime HVAnsaettelsedato { get; set; }
        public string HVEfternavn { get; set; }
        public string HVFagomraade { get; set; }
        public string HVFornavn { get; set; }
    }
}
