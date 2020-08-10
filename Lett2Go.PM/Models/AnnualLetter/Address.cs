using System;

// ReSharper disable IdentifierTypo
namespace Lett2Go.PM.Models.AnnualLetter
{
    public partial class Address
    {
        public string Ssn { get; set; }
        public string PrimaryRep { get; set; }
        public string PrimaryRepName { get; set; }
        public string Company { get; set; }
        public string Firstname { get; set; }
        public string Middleinitial { get; set; }
        public string Email { get; set; }
        public string Lastname { get; set; }
        public DateTime? Birthdate { get; set; }
        public bool? DobApplicable { get; set; }
        public string Maritalstatus { get; set; }
        public string Citizenship { get; set; }
        public string Bankind { get; set; }
        public string Dirind { get; set; }
        public string Foreignind { get; set; }
        public string DaytimePhone { get; set; }
        public string EveningPhone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Statecode { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string Empstatus { get; set; }
        public string Empname { get; set; }
        public string Empaddress1 { get; set; }
        public string Empaddress2 { get; set; }
        public string Empcity { get; set; }
        public string Empstatecode { get; set; }
        public string Empzipcode { get; set; }
        public bool HasPoliticalAffiliation { get; set; }
        public bool? Isforeignaddress { get; set; }
        public bool IsForeign { get; set; }
        public string Occupation { get; set; }
    }
}
