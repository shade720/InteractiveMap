namespace InteractiveMap.DataAccessLayer
{
    public class MapState
    {
        public double Zoom { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public GMap.NET.MapProviders.GMapProvider MapProvider { get; set; }
    }
}
