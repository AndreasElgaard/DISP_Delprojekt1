using API.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class VaerkToejsKasseRepository : Repository<Vaerktoejskasse>, IVaerkToejsKasseRepository, IDisposable
    {
        private bool disposed = false;

        public VaerkToejsKasseRepository(ApplicationContext context) : base(context)
        {
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
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
