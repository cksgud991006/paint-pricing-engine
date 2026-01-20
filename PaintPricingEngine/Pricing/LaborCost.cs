namespace PaintPricingEngine.Pricing;
public record LaborCost
{
    public double BaseHourlyRate { get; private set;}
    public double LaborCostPerSqft { get; private set;}
    
    public static LaborCost Create(double baseHourlyRate, double laborCostPerSqft)
    {

        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(baseHourlyRate);

        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(laborCostPerSqft);

        // TODO: Set Business allowed minimum-maximum limit of work rate
        ArgumentOutOfRangeException.ThrowIfLessThan(baseHourlyRate, 0.0);

        //ArgumentOutOfRangeException.ThrowIfGreaterThan(baseHourlyRate, null);

        ArgumentOutOfRangeException.ThrowIfLessThan(laborCostPerSqft, 0.0);

        //ArgumentOutOfRangeException.ThrowIfGreaterThan(laborCostPerSqft, null);
        
        return new LaborCost
        {
            BaseHourlyRate = baseHourlyRate,
            LaborCostPerSqft = laborCostPerSqft
        };
    }
};