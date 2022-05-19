namespace FlyweightLocation;

public class LocationIconFactory
{
    private readonly Dictionary<LocationType, LocationIcon> _icons = new();
    public LocationIcon GetPointIcon(LocationType type)
    {
        if (!_icons.ContainsKey(type))
        {
            var icon = new LocationIcon(type, null);
            _icons.Add(type, icon);
        }

        return _icons[type];
    }
}