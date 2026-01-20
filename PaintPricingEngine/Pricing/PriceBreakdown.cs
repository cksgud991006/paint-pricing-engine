namespace PaintPricingEngine.Pricing;
public record PriceBreakdown
{
    public double BaseLaborRatePerSqft { get; private set;}
    public double TotalRatePerSqft { get; private set;}
    public double SubTotal { get; private set;}

    public static PriceBreakdown Create(double baseLaborRatePerSqft, double totalRatePerSqft, double subTotal)
    {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(baseLaborRatePerSqft, 0);

        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(totalRatePerSqft, 0);
        

        return new PriceBreakdown
        {
            BaseLaborRatePerSqft = baseLaborRatePerSqft,
            TotalRatePerSqft = totalRatePerSqft,
            SubTotal = subTotal
        };
    }
}