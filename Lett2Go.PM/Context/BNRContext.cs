using System.Configuration;
using Lett2Go.PM.Models.BnR;
using Microsoft.EntityFrameworkCore;

namespace Lett2Go.PM.Context
{
    public partial class BNRContext : DbContext
    {
        public BNRContext()
        {
        }

        public BNRContext(DbContextOptions<BNRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressAssociation> AddressAssociation { get; set; }
        public virtual DbSet<Advisor> Advisor { get; set; }
        public virtual DbSet<AuditTrail> AuditTrail { get; set; }
        public virtual DbSet<BnrAppConfig> BnrAppConfig { get; set; }
        public virtual DbSet<CambridgeAccount> CambridgeAccount { get; set; }
        public virtual DbSet<CambridgeAccountAdvisor> CambridgeAccountAdvisor { get; set; }
        public virtual DbSet<CambridgeAccountClient> CambridgeAccountClient { get; set; }
        public virtual DbSet<CambridgeAccountClientReadOnly> CambridgeAccountClientReadOnly { get; set; }
        public virtual DbSet<CambridgeAccountReadOnly> CambridgeAccountReadOnly { get; set; }
        public virtual DbSet<CambridgeSponsorAccount> CambridgeSponsorAccount { get; set; }
        public virtual DbSet<CambridgeSuitabilityInformation> CambridgeSuitabilityInformation { get; set; }
        public virtual DbSet<CambridgeTrustedContact> CambridgeTrustedContact { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<LetterExclusion> LetterExclusion { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<PdfLetter> PdfLetter { get; set; }
        public virtual DbSet<SponsorAccount> SponsorAccount { get; set; }
        public virtual DbSet<SuitabilityInformation> SuitabilityInformation { get; set; }
        public virtual DbSet<TrustedContact> TrustedContact { get; set; }
        public virtual DbSet<ValidationReport> ValidationReport { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //  #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BNR"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.AddressId).ValueGeneratedNever();

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AddressAssociation>(entity =>
            {
                entity.HasIndex(e => e.AddressId)
                    .HasName("IX_AddressId");

                entity.Property(e => e.AddressAssociationId).ValueGeneratedNever();

                entity.Property(e => e.AddressType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveEnd).HasColumnType("datetime");

                entity.Property(e => e.EffectiveStart).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.UserType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.AddressAssociation)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AddressAssociation_dbo.Address_AddressId");
            });

            modelBuilder.Entity<Advisor>(entity =>
            {
                entity.Property(e => e.AdvisorId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RepCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RepPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditTrail>(entity =>
            {
                entity.Property(e => e.AuditTrailId).ValueGeneratedNever();

                entity.Property(e => e.AuditType)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EntityName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedEntity).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BnrAppConfig>(entity =>
            {
                entity.Property(e => e.BnrAppconfigId).ValueGeneratedNever();

                entity.Property(e => e.ConfigJson)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigType)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CambridgeAccount>(entity =>
            {
                entity.HasIndex(e => e.FinancialAdvisorId)
                    .HasName("IX_FinancialAdvisorId");

                entity.HasIndex(e => e.FinancialInfoId)
                    .HasName("IX_FinancialInfoId");

                entity.HasIndex(e => e.PrimaryClientId)
                    .HasName("IX_PrimaryClientId");

                entity.HasIndex(e => e.TrustedContactId)
                    .HasName("IX_TrustedContactId");

                entity.Property(e => e.CambridgeAccountId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExtractDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.HasOne(d => d.FinancialAdvisor)
                    .WithMany(p => p.CambridgeAccount)
                    .HasForeignKey(d => d.FinancialAdvisorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CambridgeAccount_dbo.CambridgeAccountAdvisor_FinancialAdvisorId");

                entity.HasOne(d => d.FinancialInfo)
                    .WithMany(p => p.CambridgeAccount)
                    .HasForeignKey(d => d.FinancialInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CambridgeAccount_dbo.SuitabilityInformation_FinancialInfoId");

                entity.HasOne(d => d.PrimaryClient)
                    .WithMany(p => p.CambridgeAccount)
                    .HasForeignKey(d => d.PrimaryClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CambridgeAccount_dbo.CambridgeAccountClient_PrimaryClientId");

                entity.HasOne(d => d.TrustedContact)
                    .WithMany(p => p.CambridgeAccount)
                    .HasForeignKey(d => d.TrustedContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CambridgeAccount_dbo.TrustedContact_TrustedContactId");
            });

            modelBuilder.Entity<CambridgeAccountAdvisor>(entity =>
            {
                entity.HasIndex(e => e.AdvisorId)
                    .HasName("IX_AdvisorId");

                entity.HasIndex(e => e.CambridgeAccountReadOnlyId)
                    .HasName("IX_CambridgeAccountReadOnlyId");

                entity.Property(e => e.CambridgeAccountAdvisorId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveEnd).HasColumnType("datetime");

                entity.Property(e => e.EffectiveStart).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.HasOne(d => d.Advisor)
                    .WithMany(p => p.CambridgeAccountAdvisor)
                    .HasForeignKey(d => d.AdvisorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CambridgeAccountAdvisor_dbo.Advisor_AdvisorId");

                entity.HasOne(d => d.CambridgeAccountReadOnly)
                    .WithMany(p => p.CambridgeAccountAdvisor)
                    .HasForeignKey(d => d.CambridgeAccountReadOnlyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CambridgeAccountAdvisor_dbo.CambridgeAccountReadOnly_CambridgeAccountReadOnlyId");
            });

            modelBuilder.Entity<CambridgeAccountClient>(entity =>
            {
                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_ClientId");

                entity.Property(e => e.CambridgeAccountClientId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveEnd).HasColumnType("datetime");

                entity.Property(e => e.EffectiveStart).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CambridgeAccountClient)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CambridgeAccountClient_dbo.Client_ClientId");
            });

            modelBuilder.Entity<CambridgeAccountClientReadOnly>(entity =>
            {
                entity.HasIndex(e => e.CambridgeAccountReadOnlyId)
                    .HasName("IX_CambridgeAccountReadOnlyId");

                entity.Property(e => e.CambridgeAccountClientReadOnlyId).ValueGeneratedNever();

                entity.Property(e => e.AffilBank)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AffilPolitical)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AffilPublicCo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AsOfDate).HasColumnType("datetime");

                entity.Property(e => e.ClientDayPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ClientDob).HasMaxLength(12);

                entity.Property(e => e.ClientEmail)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ClientEmploymentStatus)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ClientHeader)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ClientHeaderAddressLine1)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ClientHeaderAddressLine2)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLegalAddress)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ClientMailingAddress)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ClientNightPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ClientOccupation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ClientSsn)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LegalAddress1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LegalAddress2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LegalCity)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LegalState)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LegalZipCode)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCity)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MailingState)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MailingZipCode)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessPeriodEnd).HasColumnType("datetime");

                entity.Property(e => e.ProcessPeriodStart).HasColumnType("datetime");

                entity.Property(e => e.SeniorOfficialNonUs)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.HasOne(d => d.CambridgeAccountReadOnly)
                    .WithMany(p => p.CambridgeAccountClientReadOnly)
                    .HasForeignKey(d => d.CambridgeAccountReadOnlyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CambridgeAccountClientReadOnly_dbo.CambridgeAccountReadOnly_CambridgeAccountReadOnlyId");
            });

            modelBuilder.Entity<CambridgeAccountReadOnly>(entity =>
            {
                entity.Property(e => e.CambridgeAccountReadOnlyId).ValueGeneratedNever();

                entity.Property(e => e.AsOfDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExtractDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessPeriodEnd).HasColumnType("datetime");

                entity.Property(e => e.ProcessPeriodStart).HasColumnType("datetime");

                entity.Property(e => e.RepAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RepCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RepName)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.RepPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CambridgeSponsorAccount>(entity =>
            {
                entity.HasIndex(e => e.CambridgeAccountReadOnlyId)
                    .HasName("IX_CambridgeAccountReadOnlyId");

                entity.HasIndex(e => e.SponsorAccountId)
                    .HasName("IX_SponsorAccountId");

                entity.Property(e => e.CambridgeSponsorAccountId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveEnd).HasColumnType("datetime");

                entity.Property(e => e.EffectiveStart).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.HasOne(d => d.CambridgeAccountReadOnly)
                    .WithMany(p => p.CambridgeSponsorAccount)
                    .HasForeignKey(d => d.CambridgeAccountReadOnlyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CambridgeSponsorAccount_dbo.CambridgeAccountReadOnly_CambridgeAccountReadOnlyId");

                entity.HasOne(d => d.SponsorAccount)
                    .WithMany(p => p.CambridgeSponsorAccount)
                    .HasForeignKey(d => d.SponsorAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CambridgeSponsorAccount_dbo.SponsorAccount_SponsorAccountId");
            });

            modelBuilder.Entity<CambridgeSuitabilityInformation>(entity =>
            {
                entity.HasIndex(e => e.CambridgeAccountReadOnlyId)
                    .HasName("IX_CambridgeAccountReadOnlyId");

                entity.HasIndex(e => e.SuitabilityInformationId)
                    .HasName("IX_SuitabilityInformationId");

                entity.Property(e => e.CambridgeSuitabilityInformationId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveEnd).HasColumnType("datetime");

                entity.Property(e => e.EffectiveStart).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.HasOne(d => d.CambridgeAccountReadOnly)
                    .WithMany(p => p.CambridgeSuitabilityInformation)
                    .HasForeignKey(d => d.CambridgeAccountReadOnlyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CambridgeSuitabilityInformation_dbo.CambridgeAccountReadOnly_CambridgeAccountReadOnlyId");

                entity.HasOne(d => d.SuitabilityInformation)
                    .WithMany(p => p.CambridgeSuitabilityInformation)
                    .HasForeignKey(d => d.SuitabilityInformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CambridgeSuitabilityInformation_dbo.SuitabilityInformation_SuitabilityInformationId");
            });

            modelBuilder.Entity<CambridgeTrustedContact>(entity =>
            {
                entity.HasIndex(e => e.CambridgeAccountReadOnlyId)
                    .HasName("IX_CambridgeAccountReadOnlyId");

                entity.HasIndex(e => e.TrustedContactId)
                    .HasName("IX_TrustedContactId");

                entity.Property(e => e.CambridgeTrustedContactId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveEnd).HasColumnType("datetime");

                entity.Property(e => e.EffectiveStart).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.HasOne(d => d.CambridgeAccountReadOnly)
                    .WithMany(p => p.CambridgeTrustedContact)
                    .HasForeignKey(d => d.CambridgeAccountReadOnlyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CambridgeTrustedContact_dbo.CambridgeAccountReadOnly_CambridgeAccountReadOnlyId");

                entity.HasOne(d => d.TrustedContact)
                    .WithMany(p => p.CambridgeTrustedContact)
                    .HasForeignKey(d => d.TrustedContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CambridgeTrustedContact_dbo.TrustedContact_TrustedContactId");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.ClientId).ValueGeneratedNever();

                entity.Property(e => e.AffilBank)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AffilPolitical)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AffilPublicCo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ClientType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DayPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentStatus)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NightPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SeniorOfficialNonUs)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LetterExclusion>(entity =>
            {
                entity.Property(e => e.LetterExclusionId).ValueGeneratedNever();

                entity.Property(e => e.AsOfDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LetterIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<PdfLetter>(entity =>
            {
                entity.HasKey(e => e.LetterId)
                    .HasName("PK_dbo.PdfLetter");

                entity.Property(e => e.AsOfDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CycleEndDate).HasColumnType("datetime");

                entity.Property(e => e.CycleStartDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SponsorAccount>(entity =>
            {
                entity.Property(e => e.SponsorAccountId).ValueGeneratedNever();

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.RegCode)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RegType)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDescription)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SuitabilityInformation>(entity =>
            {
                entity.Property(e => e.SuitabilityInformationId).ValueGeneratedNever();

                entity.Property(e => e.AccountIncome)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Bonds).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BondsExp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CashBankProd).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CashBankProdExp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Commodities).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CommoditiesExp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FedTaxBracket)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FinInfo)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceAnnuities).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsuranceAnnuitiesExp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IntervalFunds).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IntervalFundsExp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LiquidAnnualExp).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LiquidSpclExp).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LiquidSpclExpTime)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MutualFunds).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MutualFundsExp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NetInvestableAssets).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetWorth)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Options).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OptionsExp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Others).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OthersExp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryInvestmentObj)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RealEstate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RealEstateExp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RegType)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RegTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReitsDppsLp).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReitsDppsLpExp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RiskTolerance)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryInvestmentObj1)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryInvestmentObj2)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Stocks).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StocksExp)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TimeHorizon)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Unspecified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnspecifiedExp)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrustedContact>(entity =>
            {
                entity.Property(e => e.TrustedContactId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DayPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.EveningPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RelToClient)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ValidationReport>(entity =>
            {
                entity.Property(e => e.ValidationReportId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ResultDictionary).IsUnicode(false);

                entity.Property(e => e.ValidationType)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
