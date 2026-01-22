using PaintPricingEngine.Pricing;

namespace PaintPricingEngine.Services;

public interface IPaintPricingService
{
    private readonly IPaintPricingRepositories _paintPricingRepositories;

    private readonly IPriceCalculator _priceCalculator;

    public IPaintPricingService(IPaintPricingRepositories paintPricingRepositories,
                                IPriceCalculator priceCalculator);

    public async Task<Result> EstimatePrice(PaintPricingRequest request);
}