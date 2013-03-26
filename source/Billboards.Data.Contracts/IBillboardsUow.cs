using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billboards.Model;

namespace Billboards.Data.Contracts
{
    public interface IBillboardsUow
    {
        void Commit();

        // Billboard repositories
        IRepository<Billboard> Billboards { get; }
        IRepository<Address> Addresses { get; }
    }
}
