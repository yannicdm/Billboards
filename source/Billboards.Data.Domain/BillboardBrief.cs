using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billboards.Model
{
    public class BillboardBrief
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public int AddressId { get; set; }
        public string DisplayName { get; set; }
        public string Coordinates { get; set; }
        public double Longitude { get; set; }
        public double Lattitude { get; set; }
        public string Type { get; set; }
    }
}
