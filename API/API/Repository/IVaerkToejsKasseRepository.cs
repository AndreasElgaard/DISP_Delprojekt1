using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public interface IVaerkToejsKasseRepository
    {
        IEnumerable<VaerktoejsKasse> GetVVaerkToejsKasser();
        VaerktoejsKasse GetVaerkToejsKasseByID(int customerId);
        void InsertVaerkToejsKassej(VaerktoejsKasse customer);
        void DeleteVaerkToejsKasse(int customerId);
        void UpdateVVaerkToejsKasse(VaerktoejsKasse customer);
        void Save();
    }
}
