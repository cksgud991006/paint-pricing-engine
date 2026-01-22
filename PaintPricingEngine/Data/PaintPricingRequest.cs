using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace PaintPricingEngine.Data;

public record PaintPricingRequestDto(
    [Required] string PropertyType,
    [Required] int BedRoomCount,
    [Required] string PaintType,
    [Required] RoomDimensionsDto Room,
    [Optional] List<WindowDto> Windows
);