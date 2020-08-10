using System;
using System.Collections.Generic;

namespace Lett2Go.PM.Models.BnR
{
    public partial class CambridgeAccountAdvisor
    {
        public CambridgeAccountAdvisor()
        {
            CambridgeAccount = new HashSet<CambridgeAccount>();
        }

        public Guid CambridgeAccountAdvisorId { get; set; }
        public Guid CambridgeAccountReadOnlyId { get; set; }
        public Guid AdvisorId { get; set; }
        public DateTime EffectiveStart { get; set; }
        public DateTime? EffectiveEnd { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }

        public virtual Advisor Advisor { get; set; }
        public virtual CambridgeAccountReadOnly CambridgeAccountReadOnly { get; set; }
        public virtual ICollection<CambridgeAccount> CambridgeAccount { get; set; }
    }
}
