using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Vaerktoejskasse
    {
        public long id { get; set; }

        public DateTime Anskaffet { get; set; }

        public string Fabrikant { get; set; }

        public string Farve { get; set; }

        public Haandvaerker EjesAF { get; set; }

        public List<Vaerktoej> Vearktoejer { get; set; }

        public string Model { get; set; }
    }
}
