using API.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class VaerkToejRepository : IVaerkToejRepository
    {
        private readonly ApplicationContext context;

        public VaerkToejRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public void DeleteVaerkToej(int customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vaerktoej> GetVaerkToejer()
        {
            throw new NotImplementedException();
        }

        public Haandvaerker GetVaerkToejrByID(int customerId)
        {
            throw new NotImplementedException();
        }

        public void InsertVaerkToej(Vaerktoej customer)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateVaerkToej(Vaerktoej customer)
        {
            throw new NotImplementedException();
        }
    }
}
