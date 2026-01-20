namespace PaintPricingEngine.Measurements;

public enum BedRoomCount
{
    Studio = 0,
    OneBedroom = 1,
    TwoBedroom = 2,
    ThreeBedroom = 3,
    FourBedroom = 4
}

public enum PropertyType
{
    Apartment,
    Townhouse,
    Condo
}

public record Property
{
    public BedRoomCount BedRoomCount { get; private set;}
    public PropertyType PropertyType { get; private set;}

    public static Property Create(BedRoomCount bedRoomCount, PropertyType propertyType) 
    {
        return new Property
        {
            BedRoomCount = bedRoomCount,
            PropertyType = propertyType
        };
    }
}