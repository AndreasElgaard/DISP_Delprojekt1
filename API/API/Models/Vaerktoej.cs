using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Vaerktoej
    {
        public Vaerktoej()
        {
            
        }

        public DateTime Anskaffet { get; set; }
        public String EjesAf { get; set; }
        public String Fabrikat { get; set; }
        public String Farve { get; set; }
        public String Model { get; set; }
        public long Serienummer { get; set; }
        public long ID { get; set; }

    }
}
