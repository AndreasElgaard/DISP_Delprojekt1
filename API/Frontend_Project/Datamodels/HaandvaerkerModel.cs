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
        public string Fornavn { get; set; }
        [Required]
        public string Efternavn { get; set; }
        [DataType(DataType.Date)]
        public DateTime Ansættelsesdato { get; set; }
        public string Fagområde { get; set; }
        public long ID { get; set; }

        public VaerktoejsKasseModel Vaerktoejskasse { get; set; }
    }
}
