namespace PaintPricingEngine.Services;
public class PaintPricingService : IPaintPricingService
{
    private readonly IPaintPricingRepositories _paintPricingRepositories;
    private readonly IPriceCalculator _priceCalculator;
    public IPaintPricingService(IPaintPricingRepositories paintPricingRepositories,
                                IPriceCalculator priceCalculator)
    {
        _paintPricingRepositories = paintPricingRepositories;
        _priceCalculator = priceCalculator;
    }

    public async Task<Result> EstimatePrice(PaintPricingRequest request)
    {
        _priceCalculator.CalculateLaborCost(request.CostInput);
    }
}