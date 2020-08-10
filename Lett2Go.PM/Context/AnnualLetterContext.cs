using System.Configuration;
using Lett2Go.PM.Models.AnnualLetter;
using Microsoft.EntityFrameworkCore;

namespace Lett2Go.PM.Context
{
    public partial class AnnualLetterContext : DbContext
    {
        public AnnualLetterContext()
        {
        }

        public AnnualLetterContext(DbContextOptions<AnnualLetterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountCorrespondenceMapping> AccountCorrespondenceMapping { get; set; }
        public virtual DbSet<AccountDetail> AccountDetail { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AnnualLetterDataShort> AnnualLetterDataShort { get; set; }
        public virtual DbSet<ClientAddresses> ClientAddresses { get; set; }
        public virtual DbSet<ClientSuitDocsCorrespondance> ClientSuitDocsCorrespondance { get; set; }
        public virtual DbSet<ClientsWhoShouldNotGetLetter> ClientsWhoShouldNotGetLetter { get; set; }
        public virtual DbSet<SecondaryClients> SecondaryClients { get; set; }
        public virtual DbSet<Ssn> Ssn { get; set; }
        public virtual DbSet<SsnbyRep> SsnbyRep { get; set; }
        public virtual DbSet<Suitability> Suitability { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["AnnualLetter"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountCorrespondenceMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AccountCorrespondenceMapping", "dbo");

                entity.Property(e => e.PrimaryClient)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SecondaryClient)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AccountDetail>(entity =>
            {
                entity.HasKey(e => new { e.Ssn, e.SponCode, e.Accttrail })
                    .HasName("pk_AccountDetail");

                entity.ToTable("AccountDetail", "dbo");

                entity.HasIndex(e => new { e.Ssn, e.IdNum, e.Primaryrep })
                    // ReSharper disable StringLiteralTypo
                    .HasName("IDX_ClientSuitDocsCorrespondance_SSN_IdNum_PrimaryRep");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SponCode)
                    .HasColumnName("sponCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Accttrail)
                    .HasColumnName("accttrail")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AdvAmap).HasColumnName("ADV_AMAP");

                entity.Property(e => e.AdvCaap).HasColumnName("ADV_CAAP");

                entity.Property(e => e.AdvCira).HasColumnName("ADV_CIRA");

                entity.Property(e => e.AdvWrap).HasColumnName("ADV_WRAP");

                entity.Property(e => e.NumberInXml).HasDefaultValueSql("((0))");

                entity.Property(e => e.Opendate)
                    .HasColumnName("opendate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrimaryRepName)
                    .HasMaxLength(104)
                    .IsUnicode(false);

                entity.Property(e => e.Primaryrep)
                    .HasColumnName("PRIMARYREP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reg00)
                    .HasColumnName("reg00")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Reg10)
                    .HasColumnName("reg10")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Reg20)
                    .HasColumnName("reg20")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RegType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sponacct)
                    .HasColumnName("sponacct")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sponname)
                    .HasColumnName("sponname")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.Ssn)
                    .HasName("pk_ssn_address");

                entity.ToTable("Address", "dbo");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Bankind)
                    .HasColumnName("bankind")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Birthdate)
                    .HasColumnName("BIRTHDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Citizenship)
                    .HasColumnName("citizenship")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DaytimePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dirind)
                    .HasColumnName("dirind")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DobApplicable).HasColumnName("DOB_APPLICABLE");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Empaddress1)
                    .HasColumnName("empaddress1")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Empaddress2)
                    .HasColumnName("empaddress2")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Empcity)
                    .HasColumnName("empcity")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Empname)
                    .HasColumnName("empname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Empstatecode)
                    .HasColumnName("empstatecode")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Empstatus)
                    .HasColumnName("empstatus")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Empzipcode)
                    .HasColumnName("empzipcode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EveningPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Foreignind)
                    .HasColumnName("foreignind")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Isforeignaddress).HasColumnName("isforeignaddress");

                entity.Property(e => e.Lastname)
                    .HasColumnName("LASTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Maritalstatus)
                    .HasColumnName("maritalstatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Middleinitial)
                    .HasColumnName("MIDDLEINITIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Occupation).HasMaxLength(40);

                entity.Property(e => e.PrimaryRep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryRepName)
                    .HasMaxLength(104)
                    .IsUnicode(false);

                entity.Property(e => e.Statecode)
                    .IsRequired()
                    .HasColumnName("statecode")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AnnualLetterDataShort>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AnnualLetterData_Short", "dbo");

                entity.Property(e => e.ClientName)
                    .HasColumnName("Client NAME")
                    .HasMaxLength(56)
                    .IsUnicode(false);

                entity.Property(e => e.ClientSsn)
                    .IsRequired()
                    .HasColumnName("Client SSN")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdNum).HasColumnName("Id_Num");

                entity.Property(e => e.RepFullName)
                    .HasColumnName("Rep Full Name")
                    .IsUnicode(false);

                entity.Property(e => e.RepPartnerCode)
                    .HasColumnName("Rep/Partner Code")
                    .HasMaxLength(21);

                entity.Property(e => e.RepPartnerName)
                    .HasColumnName("Rep/Partner Name")
                    .HasMaxLength(104)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientAddresses>(entity =>
            {
                entity.HasKey(e => new { e.Ssn, e.AddressType })
                    .HasName("PK_ClientAddresses_SSN_AddressType");

                entity.ToTable("ClientAddresses", "dbo");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.AddressType)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Address1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Statecode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ClientSuitDocsCorrespondance>(entity =>
            {
                entity.HasKey(e => new { e.PrimaryClient, e.Idnum, e.Client })
                    .HasName("pk_ClientSuitDocsCorrespondance");

                entity.ToTable("ClientSuitDocsCorrespondance", "dbo");

                entity.HasIndex(e => e.Client)
                    .HasName("IDX_ClientSuitDocsCorrespondance_Client");

                entity.Property(e => e.PrimaryClient)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Idnum).HasColumnName("IDNUM");

                entity.Property(e => e.Client)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryOrSecondary)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientsWhoShouldNotGetLetter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClientsWhoShouldNotGetLetter", "dbo");

                entity.Property(e => e.AdvAmap)
                    .IsRequired()
                    .HasColumnName("ADV_AMAP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AdvCaap)
                    .IsRequired()
                    .HasColumnName("ADV_CAAP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AdvCira)
                    .IsRequired()
                    .HasColumnName("ADV_CIRA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AdvEthics).HasColumnName("Adv_Ethics");

                entity.Property(e => e.AdvWrap)
                    .IsRequired()
                    .HasColumnName("ADV_WRAP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageAccts).HasColumnName("Brokerage_Accts");

                entity.Property(e => e.CountNotHouse).HasColumnName("Count_Not_House");

                entity.Property(e => e.HasLetterGenerated).HasColumnName("Has_Letter_Generated");

                entity.Property(e => e.HouseAcct).HasColumnName("House_Acct");

                entity.Property(e => e.IdNum).HasColumnName("Id_Num");

                entity.Property(e => e.LastModDate).HasColumnType("datetime");

                entity.Property(e => e.LastModId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LetterType).HasColumnName("Letter_Type");

                entity.Property(e => e.PrimaryRepName)
                    .HasMaxLength(104)
                    .IsUnicode(false);

                entity.Property(e => e.Primaryrep)
                    .IsRequired()
                    .HasColumnName("PRIMARYREP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .IsRequired()
                    .HasColumnName("SSN")
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SecondaryClients>(entity =>
            {
                entity.HasKey(e => new { e.Ssn, e.Secondary, e.Idnum })
                    .HasName("pk_secondary");

                entity.ToTable("SecondaryClients", "dbo");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Secondary)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Idnum).HasColumnName("idnum");

                entity.Property(e => e.Bankind)
                    .HasColumnName("bankind")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Birthdate)
                    .HasColumnName("BIRTHDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Citizenship)
                    .HasColumnName("citizenship")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DaytimePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dirind)
                    .HasColumnName("dirind")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DobApplicable).HasColumnName("DOB_APPLICABLE");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Empaddress1)
                    .HasColumnName("empaddress1")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Empaddress2)
                    .HasColumnName("empaddress2")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Empcity)
                    .HasColumnName("empcity")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Empname)
                    .HasColumnName("empname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Empstatecode)
                    .HasColumnName("empstatecode")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Empstatus)
                    .HasColumnName("empstatus")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Empzipcode)
                    .HasColumnName("empzipcode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EveningPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Foreignind)
                    .HasColumnName("foreignind")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lastname)
                    .HasColumnName("LASTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Maritalstatus)
                    .HasColumnName("maritalstatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Middleinitial)
                    .HasColumnName("MIDDLEINITIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ssn>(entity =>
            {
                entity.HasKey(e => e.Ssn1);

                entity.ToTable("SSN", "dbo");

                entity.Property(e => e.Ssn1)
                    .HasColumnName("SSN")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.AdvAmap)
                    .IsRequired()
                    .HasColumnName("ADV_AMAP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AdvCaap)
                    .IsRequired()
                    .HasColumnName("ADV_CAAP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AdvCira)
                    .IsRequired()
                    .HasColumnName("ADV_CIRA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AdvEthics)
                    .HasColumnName("Adv_Ethics")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AdvWrap)
                    .IsRequired()
                    .HasColumnName("ADV_WRAP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BrokerageAccts)
                    .HasColumnName("Brokerage_Accts")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CountNotHouse).HasColumnName("Count_Not_House");

                entity.Property(e => e.HasLetterGenerated).HasColumnName("Has_Letter_Generated");

                entity.Property(e => e.HouseAcct)
                    .HasColumnName("House_Acct")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdNum)
                    .HasColumnName("Id_Num")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsHouseRep)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModDate).HasColumnType("datetime");

                entity.Property(e => e.LastModId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LetterType)
                    .HasColumnName("Letter_Type")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SsnbyRep>(entity =>
            {
                entity.HasKey(e => new { e.Ssn, e.Primaryrep });

                entity.ToTable("SSNByRep", "dbo");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Primaryrep)
                    .HasColumnName("PRIMARYREP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdvAmap)
                    .IsRequired()
                    .HasColumnName("ADV_AMAP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AdvCaap)
                    .IsRequired()
                    .HasColumnName("ADV_CAAP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AdvCira)
                    .IsRequired()
                    .HasColumnName("ADV_CIRA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AdvEthics)
                    .HasColumnName("Adv_Ethics")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AdvWrap)
                    .IsRequired()
                    .HasColumnName("ADV_WRAP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BrokerageAccts)
                    .HasColumnName("Brokerage_Accts")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CountNotHouse).HasColumnName("Count_Not_House");

                entity.Property(e => e.HasLetterGenerated).HasColumnName("Has_Letter_Generated");

                entity.Property(e => e.HouseAcct)
                    .HasColumnName("House_Acct")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdNum)
                    .HasColumnName("Id_Num")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsHouseRep)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsIraadvantage)
                    .HasColumnName("IsIRAAdvantage")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.LastModDate).HasColumnType("datetime");

                entity.Property(e => e.LastModId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LetterType)
                    .HasColumnName("Letter_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrimaryRepName)
                    .HasMaxLength(104)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Suitability>(entity =>
            {
                entity.HasKey(e => new { e.Ssn, e.IdNum })
                    .HasName("pk_ssn_suit");

                entity.ToTable("Suitability", "dbo");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Annualincomedesc)
                    .HasColumnName("annualincomedesc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bonds)
                    .HasColumnName("bonds")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CashBankProductsAmt).HasColumnType("money");

                entity.Property(e => e.Commodities)
                    .HasColumnName("commodities")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Descr)
                    .HasColumnName("descr")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialInformation)
                    .HasColumnName("financial_information")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InsAnnuities)
                    .HasColumnName("ins_annuities")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.KycBondsCurrHoldingsAmt)
                    .HasColumnName("KYC_BondsCurrHoldingsAmt")
                    .HasColumnType("money");

                entity.Property(e => e.KycCommCurrHoldingsAmt)
                    .HasColumnName("KYC_CommCurrHoldingsAmt")
                    .HasColumnType("money");

                entity.Property(e => e.KycIacurrHoldingsAmt)
                    .HasColumnName("KYC_IACurrHoldingsAmt")
                    .HasColumnType("money");

                entity.Property(e => e.KycIntervalFundsAmt)
                    .HasColumnName("KYC_IntervalFundsAmt")
                    .HasColumnType("money");

                entity.Property(e => e.KycLiquidityAnnualAmt)
                    .HasColumnName("KYC_LiquidityAnnualAmt")
                    .HasColumnType("money");

                entity.Property(e => e.KycLiquiditySpecialAmt)
                    .HasColumnName("KYC_LiquiditySpecialAmt")
                    .HasColumnType("money");

                entity.Property(e => e.KycMfcurrHoldingsAmt)
                    .HasColumnName("KYC_MFCurrHoldingsAmt")
                    .HasColumnType("money");

                entity.Property(e => e.KycOptionsCurrHoldingsAmt)
                    .HasColumnName("KYC_OptionsCurrHoldingsAmt")
                    .HasColumnType("money");

                entity.Property(e => e.KycOtherCurrHoldingsAmt)
                    .HasColumnName("KYC_OtherCurrHoldingsAmt")
                    .HasColumnType("money");

                entity.Property(e => e.KycRecurrHoldingsAmt)
                    .HasColumnName("KYC_RECurrHoldingsAmt")
                    .HasColumnType("money");

                entity.Property(e => e.KycReitDppLpcurrHoldingsAmt)
                    .HasColumnName("KYC_REIT_DPP_LPCurrHoldingsAmt")
                    .HasColumnType("money");

                entity.Property(e => e.KycRiskTolerance)
                    .HasColumnName("KYC_RiskTolerance")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.KycSpecialExpensesTimeframe)
                    .HasColumnName("KYC_SpecialExpensesTimeframe")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.KycStocksCurrHoldingsAmt)
                    .HasColumnName("KYC_StocksCurrHoldingsAmt")
                    .HasColumnType("money");

                entity.Property(e => e.KycUnspecifiedAmt)
                    .HasColumnName("KYC_UnspecifiedAmt")
                    .HasColumnType("money");

                entity.Property(e => e.Liquidnetworth)
                    .HasColumnName("liquidnetworth")
                    .HasColumnType("decimal(13, 2)");

                entity.Property(e => e.Mutualfunds)
                    .HasColumnName("mutualfunds")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Networth)
                    .HasColumnName("networth")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Objective1)
                    .HasColumnName("OBJECTIVE1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Objective2)
                    .HasColumnName("OBJECTIVE2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Objective3)
                    .HasColumnName("OBJECTIVE3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Options)
                    .HasColumnName("options")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Other)
                    .HasColumnName("OTHER")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Partnerships)
                    .HasColumnName("partnerships")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Realestate)
                    .HasColumnName("realestate")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Stocks)
                    .HasColumnName("stocks")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SuitName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Timehorizon)
                    .HasColumnName("timehorizon")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
