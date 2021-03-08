using API.DataBaseContext;
using API.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class HaandVaerkerRepository : IHaandVaerkerRepository
    {
        private readonly ApplicationContext context;

        public HaandVaerkerRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public void DeleteHaandVaerker(int customerId)
        {
            throw new NotImplementedException();
        }

        public Haandvaerker GetHaandVaerkerByID(int customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetHaandVaerkere()
        {
            throw new NotImplementedException();
        }

        public void InsertHaandVaerker(Haandvaerker customer)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateHaandVaerker(Haandvaerker customer)
        {
            throw new NotImplementedException();
        }
    }
}
