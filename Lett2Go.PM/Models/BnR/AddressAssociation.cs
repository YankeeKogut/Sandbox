using System;

namespace Lett2Go.PM.Models.BnR
{
    public partial class AddressAssociation
    {
        public Guid AddressAssociationId { get; set; }
        public string AddressType { get; set; }
        public string UserType { get; set; }
        public Guid UserId { get; set; }
        public Guid AddressId { get; set; }
        public DateTime EffectiveStart { get; set; }
        public DateTime? EffectiveEnd { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }

        public virtual Address Address { get; set; }
    }
}
