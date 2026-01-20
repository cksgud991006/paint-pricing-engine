namespace PaintPricingEngine.Domains;
public record Labor
{
    public double BaseHourlyRate { get; private set;}
    public double SquareFootPerHour { get; private set;}
    public static Labor Create(double baseHourlyRate, double squareFootPerHour)
    {
        return new Labor
        {
            BaseHourlyRate = baseHourlyRate,
            SquareFootPerHour = squareFootPerHour
        };
    }
}