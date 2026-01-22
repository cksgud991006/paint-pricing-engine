namespace PaintPricingEngine.Pricing;
public interface IPricecalculator
{
    public PriceBreakdown CalculateLaborCost(CostInput input);
}