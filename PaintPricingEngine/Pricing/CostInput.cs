using PaintPricingEngine.Measurements;

namespace PaintPricingEngine.Pricing;
public record CostInput
{
    public LaborCost LaborCost;
    public PaintCost PaintCost;
    public Area Area;
}