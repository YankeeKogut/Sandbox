using System;

namespace Lett2Go.PM.Models.BnR
{
    public partial class LetterExclusion
    {
        public Guid LetterExclusionId { get; set; }
        public Guid CambridgeId { get; set; }
        public long LetterNum { get; set; }
        public int LetterRecipientType { get; set; }
        public string Reason { get; set; }
        public int EventType { get; set; }
        public string LetterIdentifier { get; set; }
        public DateTime AsOfDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
    }
}
