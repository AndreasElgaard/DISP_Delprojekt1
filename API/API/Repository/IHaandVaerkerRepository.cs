using API.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    
    public interface IHaandVaerkerRepository
    {
        IEnumerable GetHaandVaerkere();
        Haandvaerker GetHaandVaerkerByID(int customerId);
        void InsertHaandVaerker(Haandvaerker customer);
        void DeleteHaandVaerker(int customerId);
        void UpdateHaandVaerker(Haandvaerker customer);
        void Save();
    }
}
