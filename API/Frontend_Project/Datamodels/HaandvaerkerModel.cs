using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Project.Datamodels
{
    public class HaandvaerkerModel
    {
        [Required]
        public string HVFornavn { get; set; }
        [Required]
        public string HVEfternavn { get; set; }
        [DataType(DataType.Date)]
        public DateTime HVAnsaettelsedato { get; set; }
        public string HVFagomraade { get; set; }
        public int HaandvaerkerId { get; set; }

        public HashSet<VaerktoejsKasseModel> Vaerktoejskasse { get; set; }
    }
}
