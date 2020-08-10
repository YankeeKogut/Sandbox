using System;
using System.Collections.Generic;

namespace Lett2Go.PM.Models.BnR
{
    public partial class Client
    {
        public Client()
        {
            CambridgeAccountClient = new HashSet<CambridgeAccountClient>();
        }

        public Guid ClientId { get; set; }
        public int ClientNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Prefix { get; set; }
        public string MiddleName { get; set; }
        public string ClientType { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public string DayPhone { get; set; }
        public string Ssn { get; set; }
        public string NightPhone { get; set; }
        public string EmploymentStatus { get; set; }
        public string Occupation { get; set; }
        public string AffilBank { get; set; }
        public string AffilPolitical { get; set; }
        public string AffilPublicCo { get; set; }
        public string SeniorOfficialNonUs { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<CambridgeAccountClient> CambridgeAccountClient { get; set; }
    }
}
