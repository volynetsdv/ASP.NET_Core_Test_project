using System.Collections.Generic;

namespace manufacturer_api_dotnet.Models
{
    public class VehicleManufacturer
    {
        public string Country { get; set; }
        public string Mfr_CommonName { get; set; }
        public int Mfr_ID { get; set; }
        public string Mfr_Name { get; set; }
        public List<VehicleType> VehicleTypes { get; set; }
    }
}