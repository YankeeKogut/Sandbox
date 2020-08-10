using System;

namespace Lett2Go.PM.Models.BnR
{
    public partial class CambridgeAccount
    {
        public Guid CambridgeAccountId { get; set; }
        public Guid PrimaryClientId { get; set; }
        public Guid FinancialAdvisorId { get; set; }
        public Guid TrustedContactId { get; set; }
        public Guid FinancialInfoId { get; set; }
        public int ClientNumber { get; set; }
        public DateTime ExtractDate { get; set; }
        public long LetterNum { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }

        public virtual CambridgeAccountAdvisor FinancialAdvisor { get; set; }
        public virtual SuitabilityInformation FinancialInfo { get; set; }
        public virtual CambridgeAccountClient PrimaryClient { get; set; }
        public virtual TrustedContact TrustedContact { get; set; }
    }
}
