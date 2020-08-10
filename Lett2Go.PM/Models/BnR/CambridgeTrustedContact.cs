using System;

namespace Lett2Go.PM.Models.BnR
{
    public partial class CambridgeTrustedContact
    {
        public Guid CambridgeTrustedContactId { get; set; }
        public Guid CambridgeSponsorAccountId { get; set; }
        public Guid CambridgeAccountReadOnlyId { get; set; }
        public Guid TrustedContactId { get; set; }
        public DateTime EffectiveStart { get; set; }
        public DateTime? EffectiveEnd { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }

        public virtual CambridgeAccountReadOnly CambridgeAccountReadOnly { get; set; }
        public virtual TrustedContact TrustedContact { get; set; }
    }
}
