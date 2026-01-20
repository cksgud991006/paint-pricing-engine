using PaintPricingEngine.Services;

namespace Paint.Endpoints;

public static class PaintEndpoints
{
    public static void MapPaintEndpoints(this WebApplication app)
    {
        
        // POST
        app.MapPost("/paint", EstimatePaint);
    }

    private static async Task<IResult> EstimatePaint(
        IPaintPricingService service)
    {
        /*
        var result = await service.IssueAsync(request.UserId);
        return result switch
        {
            { IsSuccess: true } =>
                Results.Created(
                    $"/coupons/{result.Coupon!.CouponId}",
                    new CouponIssueResponse(
                        result.Coupon!.UserId,
                        result.Coupon!.CouponId
                    )
                ),

            { FailureReason: CouponIssueFailureReason.AlreadyIssued } =>
                Results.Conflict("Coupon already issued"),

            { FailureReason: CouponIssueFailureReason.SoldOut } =>
                Results.Conflict("Coupon sold out"),

            _ =>
                Results.StatusCode(500)
        };
        */
    }
}