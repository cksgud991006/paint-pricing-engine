using System.ComponentModel.DataAnnotations;

namespace PaintPricingEngine.Data;

public record RoomDimensionsDto(
    [Required] double LengthFeet,
    [Required] double WidthFeet,    
    [Required] double HeightFeet
);