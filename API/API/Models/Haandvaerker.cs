using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Haandvaerker
    {
       
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public DateTime Ansættelsesdato { get; set; }
        public string Fagområde { get; set; }
        public long ID { get; set; }

        public Vaerktoejskasse Vaerktoejskasse { get; set; }
    }
}
