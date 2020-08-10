using System;

namespace Lett2Go.PM.Models.BnR
{
    public partial class CambridgeAccountClientReadOnly
    {
        public Guid CambridgeAccountClientReadOnlyId { get; set; }
        public Guid CambridgeAccountReadOnlyId { get; set; }
        public Guid CambridgeAccountId { get; set; }
        public Guid ClientId { get; set; }
        public bool IsPrimary { get; set; }
        public int ClientNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ClientName { get; set; }
        public string ClientDob { get; set; }
        public string LegalAddress1 { get; set; }
        public string LegalAddress2 { get; set; }
        public string LegalCity { get; set; }
        public string LegalState { get; set; }
        public string LegalZipCode { get; set; }
        public string MailingAddress1 { get; set; }
        public string MailingAddress2 { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        public string MailingZipCode { get; set; }
        public string ClientMailingAddress { get; set; }
        public string ClientHeaderAddressLine1 { get; set; }
        public string ClientHeaderAddressLine2 { get; set; }
        public string ClientHeader { get; set; }
        public string ClientLegalAddress { get; set; }
        public string ClientEmail { get; set; }
        public string ClientDayPhone { get; set; }
        public string ClientSsn { get; set; }
        public string ClientNightPhone { get; set; }
        public string ClientEmploymentStatus { get; set; }
        public string ClientOccupation { get; set; }
        public string AffilBank { get; set; }
        public string AffilPolitical { get; set; }
        public string AffilPublicCo { get; set; }
        public string SeniorOfficialNonUs { get; set; }
        public string Company { get; set; }
        public DateTime AsOfDate { get; set; }
        public DateTime ProcessPeriodStart { get; set; }
        public DateTime ProcessPeriodEnd { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }

        public virtual CambridgeAccountReadOnly CambridgeAccountReadOnly { get; set; }
    }
}
