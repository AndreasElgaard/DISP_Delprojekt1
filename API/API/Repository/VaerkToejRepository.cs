using API.DataBaseContext;
using System;
using API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class VaerkToejRepository : Repository<Vaerktoej>, IVaerkToejRepository, IDisposable
    {
        private bool disposed = false;

        public VaerkToejRepository(ApplicationContext context) : base(context)
        {
    
        }

       
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
