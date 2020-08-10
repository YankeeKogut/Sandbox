using System;
using System.Collections.Generic;

namespace Lett2Go.PM.Models.BnR
{
    public partial class SponsorAccount
    {
        public SponsorAccount()
        {
            CambridgeSponsorAccount = new HashSet<CambridgeSponsorAccount>();
        }

        public Guid SponsorAccountId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string RegistrationDescription { get; set; }
        public string RegType { get; set; }
        public string RegCode { get; set; }
        public DateTime? OpenDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<CambridgeSponsorAccount> CambridgeSponsorAccount { get; set; }
    }
}
