using System.Collections.Generic;
using Nyble.Web.Co2.Models;

namespace Nyble.Web.Co2.Services.TravelClassService
{
    public class TravelClassService : ITravelClassService
    {
        public TravelClass GetDefaultTravelClass()
        {
            return TravelClass.AveragePassenger;
        }

        public Dictionary<TravelClass, double> GetDomesticEmissions()
        {
            return new Dictionary<TravelClass, double>()
            {
                { TravelClass.AveragePassenger, 0.25355 }
            };
        }

        public Dictionary<TravelClass, double> GetShortHaulFromUkEmissions()
        {
            return new Dictionary<TravelClass, double>()
            {
                { TravelClass.AveragePassenger, 0.15753 },
                { TravelClass.EconomyClass, 0.15495 },
                { TravelClass.BusinessClass, 0.23243 }
            };
        }

        public Dictionary<TravelClass, double> GetLongHaulFromUkEmissions()
        {
            return new Dictionary<TravelClass, double>()
            {
                { TravelClass.AveragePassenger, 0.19464 },
                { TravelClass.EconomyClass, 0.14906 },
                { TravelClass.PremiumEconomyClass, 0.2385 },
                { TravelClass.BusinessClass, 0.43229 },
                { TravelClass.FirstClass, 0.59626 }
            };
        }

        public Dictionary<TravelClass, double> GetInternationalEmissions()
        {
            return new Dictionary<TravelClass, double>()
            {
                { TravelClass.AveragePassenger, 0.17987 },
                { TravelClass.EconomyClass, 0.13775 },
                { TravelClass.PremiumEconomyClass, 0.2204 },
                { TravelClass.BusinessClass, 0.39948},
                { TravelClass.FirstClass, 0.551 }
            };
        }
    }
}