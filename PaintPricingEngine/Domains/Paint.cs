namespace PaintPricingEngine.Domains;

public enum PaintType
{
    Standard,
    Premium,
    Ecofriendly
};

public record Paint
{
    public PaintType PaintType { get; private set;}
    public double CostPerSquareFeet { get; private set;}

    public static Paint Create(PaintType paintType, double costPerSquareFeet)
    {
        return new Paint
        {
            PaintType = paintType,
            CostPerSquareFeet = costPerSquareFeet
        };
    }
}