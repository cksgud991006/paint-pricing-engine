namespace PaintPricingEngine.Pricing;

public class PriceCalculator: IPricecalculator
{
    public PriceBreakdown EstimateLaborCost(CostInput input)
    {
        var baseLaborRatePerSqft = input.LaborCost.BaseHourlyRate * input.LaborCost.LaborCostPerSqft;
        var totalRatePerSqft = baseLaborRatePerSqft + input.PaintCost.PaintCostPerSqft;
        var subTotal = totalRatePerSqft * input.Area.SquareFeet;

        return PriceBreakdown.Create(baseLaborRatePerSqft, totalRatePerSqft, subTotal);
    }
}