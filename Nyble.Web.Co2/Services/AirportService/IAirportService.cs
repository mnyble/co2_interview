using System.Collections.Generic;
using System.Threading.Tasks;
using Nyble.Web.Co2.Models.Dto;

namespace Nyble.Web.Co2.Services.AirportService
{
    public interface IAirportService
    {
        Task<IEnumerable<AirportDto>> GetAirportsAsync();
        Task<AirportDto> GetAirportAsync(string iata);
    }
}