using FlyweightLocation;

var service = new LocationService(new LocationIconFactory());

var points = service.GetLocations();

points.ForEach(a => a.Draw());