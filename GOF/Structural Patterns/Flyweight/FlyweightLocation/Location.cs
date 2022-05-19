namespace FlyweightLocation;

public class Location
{
    public int Longitude { get; private set; }
    public int Latitude { get; private set; }
    public LocationIcon LocationIcon { get; private set; }


    public Location(int longitude, int latitude, LocationIcon locationIcon)
    {
        Longitude = longitude;
        Latitude = latitude;
        LocationIcon = locationIcon;
    }

    public void Draw()
    {
        Console.WriteLine($"{LocationIcon.LocationType}-({Longitude},{Latitude})");
    }
}