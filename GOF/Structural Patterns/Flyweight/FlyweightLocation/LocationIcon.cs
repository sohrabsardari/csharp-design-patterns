namespace FlyweightLocation;

public class LocationIcon
{
    public LocationType LocationType { get; private set; }
    public byte[] Icon { get; private set; }

    public LocationIcon(LocationType locationType, byte[] icon)
    {
        LocationType = locationType;
        Icon = icon;
    }
}