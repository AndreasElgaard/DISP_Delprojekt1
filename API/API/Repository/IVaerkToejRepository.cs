using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public interface IVaerkToejRepository : IRepository<Vaerktoej>
    {
        void Save();
    }
}
