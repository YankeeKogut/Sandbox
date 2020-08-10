using System;

namespace Lett2Go.PM.Models.BnR
{
    public partial class AuditTrail
    {
        public Guid AuditTrailId { get; set; }
        public string EntityName { get; set; }
        public string ModifiedEntity { get; set; }
        public string AuditType { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
