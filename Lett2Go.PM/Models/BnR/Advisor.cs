using System;
using System.Collections.Generic;

namespace Lett2Go.PM.Models.BnR
{
    public partial class Advisor
    {
        public Advisor()
        {
            CambridgeAccountAdvisor = new HashSet<CambridgeAccountAdvisor>();
        }

        public Guid AdvisorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Suffix { get; set; }
        public string Prefix { get; set; }
        public string RepPhone { get; set; }
        public string RepCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<CambridgeAccountAdvisor> CambridgeAccountAdvisor { get; set; }
    }
}
