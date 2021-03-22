using API.DataBaseContext;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureCreated();

            //// Look for any students.
            //if (context.Haandværkere.Any())
            //{
            //    return;   // DB has been seeded
            //}

            //var vaerktoejs = new Vaerktoej[]
            //{
            //new Vaerktoej{VTAnskaffet=DateTime.Parse("2005-09-01"),VTFabrikat="Chemistry", VTModel="2001", VTSerienr="00010123", VTType= "Skrue"},
            //new Vaerktoej{VTAnskaffet=DateTime.Parse("2005-09-01"),VTFabrikat="Chemistry", VTModel="2001", VTSerienr="00010123", VTType= "Skrue"},
            //new Vaerktoej{VTAnskaffet=DateTime.Parse("2005-09-01"),VTFabrikat="Chemistry", VTModel="2001", VTSerienr="00010123", VTType= "Skrue"},
            //new Vaerktoej{VTAnskaffet=DateTime.Parse("2005-09-01"),VTFabrikat="Chemistry", VTModel="2001", VTSerienr="00010123", VTType= "Skrue"},
            //new Vaerktoej{VTAnskaffet=DateTime.Parse("2005-09-01"),VTFabrikat="Chemistry", VTModel="2001", VTSerienr="00010123", VTType= "Skrue"},
            //new Vaerktoej{VTAnskaffet=DateTime.Parse("2005-09-01"),VTFabrikat="Chemistry", VTModel="2001", VTSerienr="00010123", VTType= "Skrue"},
            //new Vaerktoej{VTAnskaffet=DateTime.Parse("2005-09-01"),VTFabrikat="Chemistry", VTModel="2001", VTSerienr="00010123", VTType= "Skrue"}
            //};
           

            //var vaerktoejskasses = new Vaerktoejskasse[]
            //{
            //new Vaerktoejskasse{VTKAnskaffet=DateTime.Parse("2005-09-01"),VTKFabrikat="Chemistry", VTKModel="2001", VTKSerienummer="00010123", VTKFarve= "Knald Rød"}
            //};
            

            var haandvearkere = new Haandvaerker[]
            {
            new Haandvaerker{HVAnsaettelsedato=DateTime.Parse("2005-09-01"), HVEfternavn="Jorgensen", HVFagomraade="Tømmer", HVFornavn="Mads"},
            new Haandvaerker{HVAnsaettelsedato=DateTime.Parse("2005-09-01"), HVEfternavn="Jorgensen", HVFagomraade="Tømmer", HVFornavn="Mads"},
            new Haandvaerker{HVAnsaettelsedato=DateTime.Parse("2005-09-01"), HVEfternavn="Jorgensen", HVFagomraade="Tømmer", HVFornavn="Mads"},
            new Haandvaerker{HVAnsaettelsedato=DateTime.Parse("2005-09-01"), HVEfternavn="Jorgensen", HVFagomraade="Tømmer", HVFornavn="Mads"},
            new Haandvaerker{HVAnsaettelsedato=DateTime.Parse("2005-09-01"), HVEfternavn="Jorgensen", HVFagomraade="Tømmer", HVFornavn="Mads"},
            new Haandvaerker{HVAnsaettelsedato=DateTime.Parse("2005-09-01"), HVEfternavn="Jorgensen", HVFagomraade="Tømmer", HVFornavn="Mads"},
            new Haandvaerker{HVAnsaettelsedato=DateTime.Parse("2005-09-01"), HVEfternavn="Jorgensen", HVFagomraade="Tømmer", HVFornavn="Mads"},
            new Haandvaerker{HVAnsaettelsedato=DateTime.Parse("2005-09-01"), HVEfternavn="Jorgensen", HVFagomraade="Tømmer", HVFornavn="Mads"},
            new Haandvaerker{HVAnsaettelsedato=DateTime.Parse("2005-09-01"), HVEfternavn="Jorgensen", HVFagomraade="Tømmer", HVFornavn="Mads"},
            };


            //foreach (Vaerktoej c in vaerktoejs)
            //{
            //    context.Vaerktøjer.Add(c);
            //}
            //context.SaveChanges();

            //foreach (Vaerktoejskasse e in vaerktoejskasses)
            //{
            //    context.Vaerktoejskasser.Add(e);
            //}
            //context.SaveChanges();


            //foreach (Haandvaerker s in haandvearkere)
            //{
            //    context.Haandværkere.Add(s);
            //}
            //context.SaveChanges();

            
        }
    }
}

