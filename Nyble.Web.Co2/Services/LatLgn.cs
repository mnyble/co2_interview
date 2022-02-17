namespace Nyble.Web.Co2.Services
{
    /// <summary>
    /// Specifies a Latitude / Longitude point.
    /// </summary>
    public class LatLng
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public LatLng()
        {
        }

        public LatLng(double lat, double lng)
        {
            this.Latitude = lat;
            this.Longitude = lng;
        }
    }
}
