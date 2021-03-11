using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Project.Datamodels
{
    public class VaerktoejModel
    {
        public long id { get; set; }
        public String LiggerIVTK { get; set; }
        public DateTime Anskaffet { get; set; }
        public String Fabrikat { get; set; }
        public string Model { get; set; }
        public long SerieNummer { get; set; }
        public string Type { get; set; }
    }
}
