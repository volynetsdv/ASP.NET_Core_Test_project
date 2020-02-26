using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using manufacturer_api_dotnet.Models;
using Newtonsoft.Json;
using System;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace manufacturer_api_dotnet.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly HttpClient _httpClient;
        //private readonly IConfiguration _configuration;
        private readonly string _baseUrl;

        public ManufacturerService(HttpClient httpClient, IConfiguration configuration)
        {
            //_configuration = configuration;
            _baseUrl = configuration["ApiUri"];
            _httpClient = httpClient;
        }

        public async Task<VehicleManufacturer> FirstManufacturerFromLargestGroup()
        {
            var responseString = await _httpClient
                .GetStringAsync($"{_baseUrl}getallmanufacturers?format=json");

            var list = JObject.Parse(responseString)["Results"].ToObject<List<VehicleManufacturer>>();

            return list.GroupBy(l => l.Country)
                .OrderBy(g => g.Count())
                .TakeLast(1)
                .SelectMany(group => group)
                .First();
        }

        public async Task<ManufacturerInfo> ManufacturerInfo(int manufacturerId)
        {
            var responseString = await _httpClient
                .GetStringAsync($"{_baseUrl}getmanufacturerdetails/{manufacturerId}?format=json");
            return JObject.Parse(responseString)["Results"][0].ToObject<ManufacturerInfo>();
        }
    }

    public interface IManufacturerService
    {
        Task<VehicleManufacturer> FirstManufacturerFromLargestGroup();
        Task<ManufacturerInfo> ManufacturerInfo(int manufacturerId);
    }
}