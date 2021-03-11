using API.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public interface IHaandVaerkerRepository : IRepository<Haandvaerker>
    {
        //specific queries for haandværker repo what is not included in the base class
        void Save();
    }
}
