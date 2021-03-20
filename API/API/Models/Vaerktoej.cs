using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Vaerktoej
    {
        [Key]
        public int Id { get; set; }
        public DateTime VTAnskaffet { get; set; }
        public string VTFabrikat { get; set; }
        public string VTModel { get; set; }
        public string VTSerienr { get; set; }
        public string VTType { get; set; }

        [ForeignKey("Id")]
        public int VaerktoejskasseId { get; set; }
        public Vaerktoejskasse Vaerktoejskasse { get; set; }
    }
}

/* 
        public long id { get; set; }
        public String LiggerIVTK { get; set; }
        public DateTime Anskaffet { get; set; }
        public String Fabrikat { get; set; }
        public string Model { get; set; }
        public long SerieNummer { get; set; }
        public string Typy { get; set; }

        public Vaerktoejskasse Vaerktoejskasse { get; set; } 
 */
