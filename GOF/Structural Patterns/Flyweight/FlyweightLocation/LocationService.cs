namespace FlyweightLocation;

public class LocationService
{
    private readonly LocationIconFactory _factory;

    public LocationService(LocationIconFactory factory)
    {
        _factory = factory;
    }

    public List<Location> GetLocations()
    {
        var locations = new List<Location>();

        var location = new Location(1, 2, _factory.GetPointIcon(LocationType.City));
        locations.Add(location);
        return locations;
    }
}