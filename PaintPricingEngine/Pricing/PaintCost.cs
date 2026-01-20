namespace PaintPricingEngine.Pricing;
public record PaintCost
{
    public double PaintCostPerSqft { get; private set;}

    public static PaintCost Create(double paintCostPerSqft)
    {

        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(paintCostPerSqft);

        return new PaintCost
        {
            PaintCostPerSqft = paintCostPerSqft
        };
    }
}