using System;
using System.Collections.Generic;

namespace Lett2Go.PM.Models.BnR
{
    public partial class TrustedContact
    {
        public TrustedContact()
        {
            CambridgeAccount = new HashSet<CambridgeAccount>();
            CambridgeTrustedContact = new HashSet<CambridgeTrustedContact>();
        }

        public Guid TrustedContactId { get; set; }
        public string RelToClient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string DayPhone { get; set; }
        public Guid SponsorAccountId { get; set; }
        public string EveningPhone { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<CambridgeAccount> CambridgeAccount { get; set; }
        public virtual ICollection<CambridgeTrustedContact> CambridgeTrustedContact { get; set; }
    }
}
