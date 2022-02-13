using System.Collections.Generic;
using Nyble.Web.Co2.Models;

namespace Nyble.Web.Co2.Services.TravelClassService
{
    public interface ITravelClassService
    {
        TravelClass GetDefaultTravelClass();
        Dictionary<TravelClass, double> GetDomesticEmissions();
        Dictionary<TravelClass, double> GetShortHaulFromUkEmissions();
        Dictionary<TravelClass, double> GetLongHaulFromUkEmissions();
        Dictionary<TravelClass, double> GetInternationalEmissions();
    }
}