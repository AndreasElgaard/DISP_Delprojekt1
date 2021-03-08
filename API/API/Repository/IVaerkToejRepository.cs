using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public interface IVaerkToejRepository
    {
        IEnumerable<Vaerktoej> GetVaerkToejer();
        Haandvaerker GetVaerkToejrByID(int customerId);
        void InsertVaerkToej(Vaerktoej customer);
        void DeleteVaerkToej(int customerId);
        void UpdateVaerkToej(Vaerktoej customer);
        void Save();
    }
}
