using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Billboards.Model;

namespace Billboards.Data.Configuration
{
    public class BillboardConfiguration : EntityTypeConfiguration<Billboard>
    {
        public BillboardConfiguration()
        {
        }
    }
}
