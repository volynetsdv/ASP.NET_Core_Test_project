
using System;
using System.Threading.Tasks;
using manufacturer_api_dotnet.Models;
using manufacturer_api_dotnet.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace manufacturer_api_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _manufacturerService;

        public ManufacturerController(IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        [HttpGet("info")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ManufacturerInfo>> ManufacturerInfo()
        {
            var manufacturer = await _manufacturerService.FirstManufacturerFromLargestGroup();

            return await _manufacturerService.ManufacturerInfo(manufacturer.Mfr_ID);
            //    should return JSON with detailted info about manufactory

        }

    }
}