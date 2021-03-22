using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Project.Datamodels
{
    public class HaandvaerkerModel
    {
        public string hvFornavn { get; set; }
        public string hvEfternavn { get; set; }
        [DataType(DataType.Date)]
        public DateTime hvAnsaettelsedato { get; set; }
        public string hvFagomraade { get; set; }
        [Key]
        public int haandvaerkerId { get; set; }
        public HashSet<VaerktoejsKasseModel> vaerktoejskasse { get; set; }
    }
}
