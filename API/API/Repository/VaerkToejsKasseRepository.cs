using API.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class VaerkToejsKasseRepository : IVaerkToejsKasseRepository
    {
        private readonly ApplicationContext context;

        public VaerkToejsKasseRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public void DeleteVaerkToejsKasse(int customerId)
        {
            throw new NotImplementedException();
        }

        public VaerktoejsKasse GetVaerkToejsKasseByID(int customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VaerktoejsKasse> GetVVaerkToejsKasser()
        {
            throw new NotImplementedException();
        }

        public void InsertVaerkToejsKassej(VaerktoejsKasse customer)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateVVaerkToejsKasse(VaerktoejsKasse customer)
        {
            throw new NotImplementedException();
        }
    }
}
