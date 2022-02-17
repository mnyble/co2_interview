using Nyble.Web.Co2.Models.Dto;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Nyble.Web.Co2.Services.AirportService
{
    public class AirportService : IAirportService
    {
        public string JsonFileName { get { return Path.Combine("data", "airports.json"); } }

        public async Task<AirportDto> GetAirportAsync(string iata)
        {
            List<AirportDto> AirportList = new List<AirportDto>(await this.GetAirportsAsync());

            return AirportList.Where(x => x.iata == iata).FirstOrDefault();
        }

        public async Task<IEnumerable<AirportDto>> GetAirportsAsync()
        {
            //JsonSerializer.Deserialize<AirportDto>("data/airports.json");

            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<IEnumerable<AirportDto>>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }

            //List<AirportDto> result = new List<AirportDto>();
            //return Task<IEnumerable<AirportDto>>;
        }
    }
}