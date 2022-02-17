using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nyble.Web.Co2.Models;
using Nyble.Web.Co2.Models.Dto;
using Nyble.Web.Co2.Services;
using Nyble.Web.Co2.Services.AirportService;
using Nyble.Web.Co2.Services.DistanceService;
using Nyble.Web.Co2.Services.TravelClassService;
using static Nyble.Web.Co2.Services.DistanceService.DistanceService;

namespace Nyble.Web.Co2.Controllers
{
    [ApiController]
    public class PingController : ControllerBase
    {
        public PingController(TravelClassService _TravelClassService, AirportService _airportService, DistanceService _distanceService)
        {
            this.travelClassService = _TravelClassService;
            this.airportService = _airportService;
            this.distanceService = _distanceService;
        }

        public TravelClassService travelClassService { get; }
        public AirportService airportService { get; }
        public DistanceService distanceService { get; }

        [HttpGet("ping")]
        public async Task<IActionResult> Get(string iata1, string iata2, TravelClass? travelClass)
        {
            if (travelClass == null)
            {
                travelClass = travelClassService.GetDefaultTravelClass();
            }

            var emission = travelClassService.GetInternationalEmissions();
            var emissionVal = emission[travelClass.Value];

            AirportDto air1 = airportService.GetAirportAsync(iata1).Result;
            AirportDto air2 = airportService.GetAirportAsync(iata2).Result;

            var air1LatLng = new LatLng(air1.lat, air1.Long);
            var air2LatLng = new LatLng(air2.lat, air2.Long);

            var distance = distanceService.HaversineDistance(air1LatLng, air2LatLng, DistanceUnit.Kilometers);
            var result = 2 * distance * emissionVal;

            return Content($"{air1.iata} + {air2.iata} + {travelClass} + {result}");
        }
    }
}
