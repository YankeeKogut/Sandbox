namespace Lett2Go.PM.Models.AnnualLetter
{
    public partial class Suitability
    {
        // ReSharper disable IdentifierTypo
        public string Ssn { get; set; }
        public string SuitName { get; set; }
        public int IdNum { get; set; }
        public int RevNum { get; set; }
        public string Annualincomedesc { get; set; }
        public string Descr { get; set; }
        public string Networth { get; set; }
        public decimal? Liquidnetworth { get; set; }
        public string Objective1 { get; set; }
        public string Objective2 { get; set; }
        public string Objective3 { get; set; }
        public string Stocks { get; set; }
        public string Bonds { get; set; }
        public string Options { get; set; }
        public string Commodities { get; set; }
        public string Realestate { get; set; }
        public string InsAnnuities { get; set; }
        public string Mutualfunds { get; set; }
        public string Partnerships { get; set; }
        public string FinancialInformation { get; set; }
        public string Timehorizon { get; set; }
        public string KycRiskTolerance { get; set; }
        public decimal? KycStocksCurrHoldingsAmt { get; set; }
        public decimal? KycBondsCurrHoldingsAmt { get; set; }
        public decimal? KycOptionsCurrHoldingsAmt { get; set; }
        public decimal? KycCommCurrHoldingsAmt { get; set; }
        public decimal? KycRecurrHoldingsAmt { get; set; }
        public decimal? KycMfcurrHoldingsAmt { get; set; }
        public decimal? KycIacurrHoldingsAmt { get; set; }
        public decimal? KycReitDppLpcurrHoldingsAmt { get; set; }
        public decimal? KycOtherCurrHoldingsAmt { get; set; }
        public string KycSpecialExpensesTimeframe { get; set; }
        public decimal? KycLiquidityAnnualAmt { get; set; }
        public decimal? KycLiquiditySpecialAmt { get; set; }
        public decimal? KycUnspecifiedAmt { get; set; }
        public decimal? CashBankProductsAmt { get; set; }
        public decimal? KycIntervalFundsAmt { get; set; }
        public string Other { get; set; }
    }
}
