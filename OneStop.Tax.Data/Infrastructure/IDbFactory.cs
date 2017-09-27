using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneStop.Tax.Data
{
    public interface IDbFactory
    {
        OneStopTaxEntities Init();
    }
}
