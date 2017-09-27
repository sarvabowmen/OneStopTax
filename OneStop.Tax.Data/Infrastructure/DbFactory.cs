using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneStop.Tax.Data
{
    public class DbFactory : Disposable
    {
        OneStopTaxEntities dbContext;

        public OneStopTaxEntities Init()
        {
            return dbContext ?? (dbContext = new OneStopTaxEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
