using System;
using System.ComponentModel.DataAnnotations;

namespace Billboards.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Address
    {
        public int Id { get; set; }
        public string AddressLine { get; set; }
        public string AdminDistrict { get; set; }
        public string CountryRegion { get; set; }
        public string Locality { get; set; }
        public string PostalCode { get; set; }
        public string FormattedAddress { get; set; }
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
