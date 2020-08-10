using System;
using System.Collections.Generic;

namespace Lett2Go.PM.Models.BnR
{
    public partial class CambridgeAccountClient
    {
        public CambridgeAccountClient()
        {
            CambridgeAccount = new HashSet<CambridgeAccount>();
        }

        public Guid CambridgeAccountClientId { get; set; }
        public Guid CambridgeAccountId { get; set; }
        public Guid ClientId { get; set; }
        public bool IsPrimary { get; set; }
        public DateTime EffectiveStart { get; set; }
        public DateTime? EffectiveEnd { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<CambridgeAccount> CambridgeAccount { get; set; }
    }
}
