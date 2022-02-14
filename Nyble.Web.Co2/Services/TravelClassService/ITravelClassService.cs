using System.Collections.Generic;
using Nyble.Web.Co2.Models;

namespace Nyble.Web.Co2.Services.TravelClassService
{
    public interface ITravelClassService
    {
        TravelClass GetDefaultTravelClass();
        Dictionary<TravelClass, double> GetDomesticEmissions();
        Dictionary<TravelClass, double> GetUkShortHaulEmissions();
        Dictionary<TravelClass, double> GetUkLongHaulEmissions();
        Dictionary<TravelClass, double> GetInternationalEmissions();
    }
}