using System;

namespace Lett2Go.PM.Models.AnnualLetter
{
    public partial class AccountCorrespondenceMapping
    {
        public Guid AccountId { get; set; }
        public string PrimaryClient { get; set; }
        public string SecondaryClient { get; set; }
        public bool PrimaryCorrespondenceClient { get; set; }
        public bool SecondaryCorrespondenceClient { get; set; }
    }
}
