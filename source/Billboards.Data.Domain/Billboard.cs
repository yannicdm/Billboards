using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Billboards.Model
{
   public class Billboard
    {
       public int Id { get; set; }
       public string Fid { get; set; }
       public int AddressId { get; set; }
       public Address Address { get; set; }
       public string DisplayName { get;  set; }
       public string Coordinates { get;  set; }
       public double Longitude { get; set; }
       public double Lattitude { get; set; }
       public string Type { get;  set; }
       public string CreatedBy { get; set; }
       public DateTime? CreatedOn { get; set; } 
       public string ModifiedBy { get; set; }     
       public DateTime? ModifiedOn { get; set; }
       public string DeletedBy { get; set; }
       public DateTime? DeletedOn { get; set; }
       public bool IsDeleted { get; set; }
       [Timestamp]
       public byte[] Timestamp { get; set; }
    }
}
