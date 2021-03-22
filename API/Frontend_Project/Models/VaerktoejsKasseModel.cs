using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Project.Datamodels
{
    public class VaerktoejsKasseModel
    {
        public int VTKId { get; set; }
        public string VTKModel { get; set; }
        public string VTKFabrikat { get; set; }
        public string VTKFarve { get; set; }
        public DateTime VTKAnskaffet { get; set; }
        public int? VTKEjesAf { get; set; }
        public HaandvaerkerModel EjesAfNavigation { get; set; }
        public string VTKSerienummer { get; set; }
        public List<VaerktoejModel> Vaerktoej { get; set; }
        
    }
}
