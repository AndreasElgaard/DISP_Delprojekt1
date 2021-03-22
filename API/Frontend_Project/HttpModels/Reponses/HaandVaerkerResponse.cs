using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers.Responses
{
    public class HaandVaerkerResponse
    {
        public int HaandvaerkerId { get; set; }
        public DateTime HVAnsaettelsedato { get; set; }
        public string HVEfternavn { get; set; }
        public string HVFagomraade { get; set; }
        public string HVFornavn { get; set; }
    }
}
