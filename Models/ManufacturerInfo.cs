using System.Collections.Generic;

namespace manufacturer_api_dotnet.Models
{
    public class ManufacturerInfo
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string ContactPhone { get; set; }
        public string Country { get; set; }
        public List<ManufacturerType> ManufacturerTypes { get; set; }
        public string Mfr_CommonName { get; set; }
        public int Mfr_ID { get; set; }
        public string Mfr_Name { get; set; }
        public string PostalCode { get; set; }
        public string PrincipalFirstName { get; set; }
        public object PrincipalLastName { get; set; }
        public string PrincipalPosition { get; set; }
        public string StateProvince { get; set; }
        public string SubmittedName { get; set; }
        public string SubmittedPosition { get; set; }
        public List<VehicleType> VehicleTypes { get; set; }
    }
}