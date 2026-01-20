namespace PaintPricingEngine.Pricing;
public interface IPricecalculator
{
    public PriceBreakdown EstimateLaborCost(CostInput input);
}