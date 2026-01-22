namespace PaintPricingEngine.Data;

public record WindowDto(
    [Required] double WidthFeet,
    [Required] double HeightFeet 
);