using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Vaerktoejskasse
    {
        [Key]
        public int VTKId { get; set; }
        public DateTime VTKAnskaffet { get; set; }
        public string VTKFabrikat { get; set; }
        public string VTKModel { get; set; }
        public string VTKSerienummer { get; set; }
        public string VTKFarve { get; set; }

        [ForeignKey("HaandvaerkerId")]
        public int HaandvaerkerId { get; set; }
        public Haandvaerker Haandvaerker { get; set; }

        public List<Vaerktoej> Vaerktoej { get; set; }
    }
}

/*
         public long id { get; set; }

        public DateTime Anskaffet { get; set; }

        public string Fabrikant { get; set; }

        public string Farve { get; set; }

        public string Model { get; set; }

        public Haandvaerker EjesAF { get; set; }

        public List<Vaerktoej> Vearktoejer { get; set; }
 */