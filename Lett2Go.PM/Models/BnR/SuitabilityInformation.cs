using System;
using System.Collections.Generic;

namespace Lett2Go.PM.Models.BnR
{
    public partial class SuitabilityInformation
    {
        public SuitabilityInformation()
        {
            CambridgeAccount = new HashSet<CambridgeAccount>();
            CambridgeSuitabilityInformation = new HashSet<CambridgeSuitabilityInformation>();
        }

        public Guid SuitabilityInformationId { get; set; }
        public string RegType { get; set; }
        public string RegTypeCode { get; set; }
        public string FinInfo { get; set; }
        public string AccountIncome { get; set; }
        public string FedTaxBracket { get; set; }
        public string NetWorth { get; set; }
        public decimal NetInvestableAssets { get; set; }
        public string PrimaryInvestmentObj { get; set; }
        public string SecondaryInvestmentObj1 { get; set; }
        public string SecondaryInvestmentObj2 { get; set; }
        public string RiskTolerance { get; set; }
        public string TimeHorizon { get; set; }
        public decimal LiquidAnnualExp { get; set; }
        public decimal LiquidSpclExp { get; set; }
        public string LiquidSpclExpTime { get; set; }
        public Guid InvestmentExperienceId { get; set; }
        public decimal Stocks { get; set; }
        public decimal Bonds { get; set; }
        public decimal Options { get; set; }
        public decimal Commodities { get; set; }
        public decimal RealEstate { get; set; }
        public decimal InsuranceAnnuities { get; set; }
        public decimal MutualFunds { get; set; }
        public decimal ReitsDppsLp { get; set; }
        public decimal Others { get; set; }
        public decimal CashBankProd { get; set; }
        public decimal Unspecified { get; set; }
        public decimal IntervalFunds { get; set; }
        public string StocksExp { get; set; }
        public string BondsExp { get; set; }
        public string OptionsExp { get; set; }
        public string CommoditiesExp { get; set; }
        public string RealEstateExp { get; set; }
        public string InsuranceAnnuitiesExp { get; set; }
        public string MutualFundsExp { get; set; }
        public string ReitsDppsLpExp { get; set; }
        public string OthersExp { get; set; }
        public string CashBankProdExp { get; set; }
        public string UnspecifiedExp { get; set; }
        public string IntervalFundsExp { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<CambridgeAccount> CambridgeAccount { get; set; }
        public virtual ICollection<CambridgeSuitabilityInformation> CambridgeSuitabilityInformation { get; set; }
    }
}
