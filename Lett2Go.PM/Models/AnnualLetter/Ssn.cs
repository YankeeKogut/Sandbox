using System;

namespace Lett2Go.PM.Models.AnnualLetter
{
    public partial class Ssn
    {
        // ReSharper disable IdentifierTypo
        public int IdNum { get; set; }
        public string Ssn1 { get; set; }
        public int IsTermed { get; set; }
        public bool IsCorrespondenceClient { get; set; }
        public bool? IsHouseRep { get; set; }
        public bool? AdvEthics { get; set; }
        public bool? HouseAcct { get; set; }
        public int? LetterType { get; set; }
        public int? BrokerageAccts { get; set; }
        public bool HasLetterGenerated { get; set; }
        public int CountNotHouse { get; set; }
        public string AdvCira { get; set; }
        public string AdvCaap { get; set; }
        public string AdvAmap { get; set; }
        public string LastModId { get; set; }
        public DateTime? LastModDate { get; set; }
        public string AdvWrap { get; set; }
    }
}
