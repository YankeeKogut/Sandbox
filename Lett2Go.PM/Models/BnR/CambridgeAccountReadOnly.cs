using System;
using System.Collections.Generic;

namespace Lett2Go.PM.Models.BnR
{
    public partial class CambridgeAccountReadOnly
    {
        public CambridgeAccountReadOnly()
        {
            CambridgeAccountAdvisor = new HashSet<CambridgeAccountAdvisor>();
            CambridgeAccountClientReadOnly = new HashSet<CambridgeAccountClientReadOnly>();
            CambridgeSponsorAccount = new HashSet<CambridgeSponsorAccount>();
            CambridgeSuitabilityInformation = new HashSet<CambridgeSuitabilityInformation>();
            CambridgeTrustedContact = new HashSet<CambridgeTrustedContact>();
        }

        public Guid CambridgeAccountReadOnlyId { get; set; }
        public Guid CambridgeAccountId { get; set; }
        public long LetterNum { get; set; }
        public int LetterReceiptType { get; set; }
        public string RepAddress { get; set; }
        public string RepName { get; set; }
        public string RepPhone { get; set; }
        public string RepCode { get; set; }
        public int EventType { get; set; }
        public DateTime ExtractDate { get; set; }
        public DateTime AsOfDate { get; set; }
        public DateTime ProcessPeriodStart { get; set; }
        public DateTime ProcessPeriodEnd { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<CambridgeAccountAdvisor> CambridgeAccountAdvisor { get; set; }
        public virtual ICollection<CambridgeAccountClientReadOnly> CambridgeAccountClientReadOnly { get; set; }
        public virtual ICollection<CambridgeSponsorAccount> CambridgeSponsorAccount { get; set; }
        public virtual ICollection<CambridgeSuitabilityInformation> CambridgeSuitabilityInformation { get; set; }
        public virtual ICollection<CambridgeTrustedContact> CambridgeTrustedContact { get; set; }
    }
}
