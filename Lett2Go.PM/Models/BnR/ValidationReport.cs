using System;

namespace Lett2Go.PM.Models.BnR
{
    public partial class ValidationReport
    {
        public Guid ValidationReportId { get; set; }
        public Guid CambridgeAccountId { get; set; }
        public long? LetterNumber { get; set; }
        public string ValidationType { get; set; }
        public string ResultDictionary { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
