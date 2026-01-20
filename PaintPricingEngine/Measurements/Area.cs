namespace PaintPricingEngine.Measurements;
public record Area
{
    public double SquareFeet { get; private set;}

    public static Area Create(double squareFeet)
    {

        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(squareFeet);

        // TODO: Set Business allowed minimum boundary to begin work
        ArgumentOutOfRangeException.ThrowIfLessThan(squareFeet, 0);

        return new Area
        {
            SquareFeet = squareFeet
        };
    }
}