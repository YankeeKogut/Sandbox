using System;

namespace Lett2Go.PM.Models.BnR
{
    public partial class PdfLetter
    {
        public long LetterId { get; set; }
        public long LetterNum { get; set; }
        public int LetterRecipientType { get; set; }
        public int EventType { get; set; }
        public Guid CambridgeAccountId { get; set; }
        public DateTime CycleStartDate { get; set; }
        public DateTime CycleEndDate { get; set; }
        public string HtmlContent { get; set; }
        public string XmlContent { get; set; }
        public DateTime AsOfDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
    }
}
