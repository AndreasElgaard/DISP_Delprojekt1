using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Repository
{
    public interface IVaerkToejsKasseRepository : IRepository<Vaerktoejskasse>
    {
        void Save();
    }
}
