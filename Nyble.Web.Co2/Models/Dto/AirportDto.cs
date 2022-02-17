using Newtonsoft.Json;

namespace Nyble.Web.Co2.Models.Dto
{
    public class AirportDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string country_code { get; set; }
        public string iata { get; set; }
        public double lat { get; set; }
        //[JsonProperty("long")]/
        public double Long { get; set; }
        public string region { get; set; }

        public override string ToString()
        {
            return $"{iata}";
        }
    }
}