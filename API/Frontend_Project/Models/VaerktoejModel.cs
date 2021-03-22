using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Project.Datamodels
{
    public class VaerktoejModel
    {
        public int VTId { get; set; }
        public string VTFabrikat { get; set; }
        public string VTModel { get; set; }
        public string VTSerienr { get; set; }
        public string VTType { get; set; }
        public DateTime VTAnskaffet { get; set; }
        public int? LiggerIvtk { get; set; }

    }
}
