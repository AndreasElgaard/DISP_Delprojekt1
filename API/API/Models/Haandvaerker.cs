using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Haandvaerker
    {
        [Key]
        public int Id { get; set; }
        public DateTime HVAnsaettelsedato { get; set; }
        public string HVEfternavn { get; set; }
        public string HVFagomraade { get; set; }
        public string HVFornavn { get; set; }

        public Vaerktoejskasse Vaerktoejskasse { get; set; }
    }
}
/*
[Required]
public string Fornavn { get; set; }
[Required]
public string Efternavn { get; set; }
public DateTime Ansættelsesdato { get; set; }
public string Fagområde { get; set; }
public long ID { get; set; }

public Vaerktoejskasse Vaerktoejskasse { get; set; }
*/