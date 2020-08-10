using System;

// ReSharper disable IdentifierTypo
namespace Lett2Go.PM.Models.AnnualLetter
{
    public partial class AccountDetail
    {
        public string Ssn { get; set; }
        public short IdNum { get; set; }
        public string Sponname { get; set; }
        public string SponCode { get; set; }
        public string Sponacct { get; set; }
        public string Accttrail { get; set; }
        public DateTime? Opendate { get; set; }
        public string Reg00 { get; set; }
        public string Reg10 { get; set; }
        public string Reg20 { get; set; }
        public string RegType { get; set; }
        public string Primaryrep { get; set; }
        public bool? AdvCira { get; set; }
        public bool? AdvCaap { get; set; }
        public bool? AdvAmap { get; set; }
        public bool? AdvWrap { get; set; }
        public string PrimaryRepName { get; set; }
        public Guid? AccountId { get; set; }
        public int? NumberInXml { get; set; }
    }
}
