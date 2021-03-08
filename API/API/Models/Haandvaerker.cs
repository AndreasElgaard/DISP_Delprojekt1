using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Haandvaerker
    {
        public Haandvaerker()
        {
            
        }
        public String Fornavn { get; set; }
        public String Efternavn { get; set; }
        public DateTime Ansættelsesdato { get; set; }
        public String Fagområde { get;  set; }
        public long ID { get; set; }
    }
}
