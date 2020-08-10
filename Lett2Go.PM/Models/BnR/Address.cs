using System;
using System.Collections.Generic;

namespace Lett2Go.PM.Models.BnR
{
    public partial class Address
    {
        public Address()
        {
            AddressAssociation = new HashSet<AddressAssociation>();
        }

        public Guid AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<AddressAssociation> AddressAssociation { get; set; }
    }
}
